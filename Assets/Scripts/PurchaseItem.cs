using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PurchaseItem : MonoBehaviour
{
    public TextMeshProUGUI numberofDiamonds;
    public PlayerInventory playerInventory;
    public InventoryUI inventoryUI;

    public TextMeshProUGUI price;
    public TextMeshProUGUI attribute; // water, fire, air, earch

    // enable image when purchase succeeded
    public Image airSlotForTechTitan;
    public Image airSlotForMayaGuide;
    public Image earthSlotForTechTitan;
    public Image earthSlotForMayaGuide;
    public Image waterSlotForTechTitan;
    public Image waterSlotForMayaGuide;
    public Image fireSlotForTechTitan;
    public Image fireSlotForMayaGuide;

    // set button interactable when purchase succeeded
    public Button airButtonForTechTitan;
    public Button earthButtonForTechTitan;
    public Button waterButtonForTechTitan;
    public Button fireButtonForTechTitan;

    // set button uninteractable after purchasing
    public Button airButtonForMaya;
    public Button earthButtonForMaya;
    public Button waterButtonForMaya;
    public Button fireButtonForMaya;

    public TextMeshProUGUI warningText;

    public void ClickPurchase()
    {
        //Transform itemNameTransform = parentObject.transform.Find("ItemName");
        if (price != null)
        {
            string priceText = price.text;
            int priceValue = int.Parse(priceText);
            Debug.Log(priceText);

            int totalDiamondNumber = int.Parse(numberofDiamonds.text);

            if (totalDiamondNumber >= priceValue)
            {
                // if owned more than required, can purchase
                //Debug.Log("can buy");
                totalDiamondNumber -= priceValue;
                //Debug.Log("remaining diamond number: " + totalDiamondNumber);

                // UPDATE PLAYER INVENTORY
                playerInventory.DiamondsSpent(priceValue);
                inventoryUI.UpdateDiamondTextAfterSpent(totalDiamondNumber);


                string attributeText = attribute.text;
                if (attributeText == "Air")
                {
                    // display Air inventory on Tech Titan's inventoryslot
                    airSlotForTechTitan.gameObject.SetActive(true);
                    airButtonForTechTitan.interactable = true;
                    airSlotForMayaGuide.gameObject.SetActive(false);
                    airButtonForMaya.interactable=false;
                }
                else if (attributeText == "Water")
                {
                    waterSlotForTechTitan.gameObject.SetActive(true);
                    waterButtonForTechTitan.interactable = true;
                    waterSlotForMayaGuide.gameObject.SetActive(false);
                    waterButtonForMaya.interactable=false;
                }
                else if (attributeText == "Fire")
                {
                    fireSlotForTechTitan.gameObject.SetActive(true);
                    fireButtonForTechTitan.interactable = true;
                    fireSlotForMayaGuide.gameObject.SetActive(false);
                    fireButtonForMaya.interactable=false;
                }
                else if (attributeText == "Earth")
                {
                    earthSlotForTechTitan.gameObject.SetActive(true);
                    earthButtonForTechTitan.interactable = true;
                    earthSlotForMayaGuide.gameObject.SetActive(false);
                    earthButtonForMaya.interactable=false;
                }
                
            }
            else {
                // if owned less than required, can't purchase
                Debug.Log("cannot buy");
                warningText.text = "Diamond is not enough!";

            }

            
        }
        else {
            Debug.Log("missing price");
        }

        
    }
}
