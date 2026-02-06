using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseInventory : MonoBehaviour
{
    public string attribute; 
    public Player techTitan;
    public HealthBar healthBar;

    public Image slotForTechTitan;
    public Button button;

    public void ClickToUse()
    {
        if (attribute == "Air")
        {
            techTitan.currentHealth += 20;
            slotForTechTitan.gameObject.SetActive(false);
            button.interactable = false;
        }
        else if (attribute == "Earth")
        {
            techTitan.currentHealth += 30;
            slotForTechTitan.gameObject.SetActive(false);
            button.interactable = false;
        }
        else if (attribute == "Fire")
        {
            techTitan.currentHealth += 60;
            slotForTechTitan.gameObject.SetActive(false);
            button.interactable = false;
        }
        else if (attribute == "Water")
        {
            techTitan.currentHealth = 100;
            slotForTechTitan.gameObject.SetActive(false);
            button.interactable = false;
        }

        if (techTitan.currentHealth > 100)
        {
            techTitan.currentHealth = 100;
        }
        healthBar.SetHealth(techTitan.currentHealth);
    }
}
