using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickKeyboard : MonoBehaviour
{
    //this script allows tech titan to pick up keyboard
    //public GameObject sprayGun;
    public Image KeyboardInInventory;
    public Button button;
   

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Triggered");
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Triggered inner");
            Destroy(this.gameObject);
            StartCoroutine(Wait());
            //sprayGun.SetActive(true);

            
            // enable Tech titan gun inventory;
            KeyboardInInventory.gameObject.SetActive(true);
            button.interactable = true;
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
    }
}
