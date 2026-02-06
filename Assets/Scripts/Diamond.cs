using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
	public AudioClip collectSound;

	private void OnTriggerEnter(Collider other)
	{
		PlayerInventory playerInventory = other.GetComponent< PlayerInventory>();
		
		if(playerInventory !=null)
		{
			playerInventory.DiamondCollected();
			PlayCollectSound();
			gameObject.SetActive(false);
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
