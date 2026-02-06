using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickGun : MonoBehaviour
{
    //public GameObject sprayGun;
    public Image paintGunInventory;
    public DisplayItem displayItem;
    public Button button;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            StartCoroutine(Wait());
            //sprayGun.SetActive(true);
            
            // enable Tech titan gun inventory;
            paintGunInventory.gameObject.SetActive(true);
            button.interactable = true;
            displayItem.isLocked = false;
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
    }
}
