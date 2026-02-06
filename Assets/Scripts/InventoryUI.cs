using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        diamondText.text = playerInventory.NumberOfDiamonds.ToString();
        
    }

    public void UpdateDiamondTextAfterSpent(int remainingDiamonds)
    {
        if(remainingDiamonds < 10)
        {
            diamondText.text = remainingDiamonds.ToString("D1");
        }
        else 
        {
            diamondText.text = remainingDiamonds.ToString("D2");
        }
        
    }
}
