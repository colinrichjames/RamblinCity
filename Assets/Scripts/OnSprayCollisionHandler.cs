using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSprayCollisionHandler : MonoBehaviour
{
    public BossBee boss;

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("bossbee"))
        {
            Debug.Log("spray collided with bee");
            boss.TakeDamage(boss.damageValueToBee);
        }
        
    }
}
