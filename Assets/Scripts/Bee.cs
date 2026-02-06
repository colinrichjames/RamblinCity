using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    //this script is for controlling the bees
    public int maxHealth = 100;
    public int currentHealth;
    public int damageValueToBee = 10;

    public HealthBar healthBar;
    private Animator beeAnim;

    public PlayerMovement pm;
    public GameObject diamondPrefab;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        beeAnim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        pm.ResetMeleePunch();
        pm.ResetPunch();

        if (currentHealth <= 0)
        {
            beeAnim.SetBool("IsAttack", false);
            beeAnim.SetBool("IsDeath", true);

            Destroy(this.gameObject, 3f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (pm.isBeingMeleePunched || pm.isBeingPunched)) 
        {
            Debug.Log("Hand");
            TakeDamage(damageValueToBee);
        }
        
        if (other.CompareTag("Keyboard") && (pm.isBeingMeleePunched || pm.isBeingPunched)) 
        {
            Debug.Log("Keyslap");
            TakeDamage(damageValueToBee * 3);
        }
    }

    private void OnDestroy()
    {
        if(!this.gameObject.scene.isLoaded) return;

        float yoffset = Random.Range(0.8f, 1.2f);
        float xoffset = 0.3f;
        Instantiate(diamondPrefab, transform.position + Vector3.up * yoffset + transform.right * xoffset, Quaternion.identity);
    }
    
}