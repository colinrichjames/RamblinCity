using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayItem : MonoBehaviour
{
    public CanvasGroup itemDescriptionCanvasGroup;
    public GameObject itemDescriptionPanel;
    public TextMeshProUGUI itemDescriptionText;
    public TextMeshProUGUI itemNameText;

    public string itemDescription;
    public string itemName;

    public TextMeshProUGUI attributeTitleText;
    public TextMeshProUGUI attributeText;
    public TextMeshProUGUI effectTitleText;
    public TextMeshProUGUI effectText;
    public TextMeshProUGUI gainTitleText;
    public TextMeshProUGUI gainText;
    public TextMeshProUGUI priceTitleText;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI priceUnitText;
    public TextMeshProUGUI waringText;
    public TextMeshProUGUI lockedText;
    public TextMeshProUGUI lockedMessageText;

    public string attributeTitle = "Attribute:";
    public string attribute;
    public string effectTitle = "Effect:";
    public string effect;
    public string gainTitle = "Energy Gain:";
    public string gain;
    public string priceTitle = "Price:";
    public string price;
    public string priceUnit = "Diamonds";
    public string warning;
    public string locked;
    public string lockedMessage;

    public GameObject purchaseButton;
    public bool isVisible = false;
    public bool isLocked = true;

    // Start is called before the first frame update
    void Start()
    {
        itemDescriptionPanel.SetActive(false);
    }

    public void OnItemClick()
    {
        
        itemNameText.text = itemName;

        attributeTitleText.text = attributeTitle;
        attributeText.text = attribute;
        effectTitleText.text = effectTitle;
        effectText.text = effect;
        gainTitleText.text = gainTitle;
        gainText.text = gain;
        priceTitleText.text = priceTitle;
        priceText.text = price;
        priceUnitText.text = priceUnit;
        waringText.text = warning;
        

        if(isLocked)
        {
            itemDescriptionText.text = "";
            lockedText.text = locked;
            lockedMessageText.text = lockedMessage;
        }
        else {
            lockedText.text = "";
            lockedMessageText.text = "";
            itemDescriptionText.text = itemDescription;
        }
        

        itemDescriptionCanvasGroup.interactable = true;
        itemDescriptionCanvasGroup.blocksRaycasts = true;
        itemDescriptionCanvasGroup.alpha = 1f;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;

        itemDescriptionPanel.SetActive(true);
        purchaseButton.SetActive(isVisible);
    }
}
