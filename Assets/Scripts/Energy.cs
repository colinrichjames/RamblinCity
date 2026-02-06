using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    //this script provides the character energy
    public Player player;
    public AudioClip collectSound;

    public int addEnergy = 25;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.AddBlood(addEnergy);
            PlayCollectSound();
            Destroy(this.gameObject);
        }
        
    }

    private void PlayCollectSound()
	{
		if (collectSound != null)
		{
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		}
	}
}
