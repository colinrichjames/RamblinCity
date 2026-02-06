using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{
    public CanvasGroup TTInventoryCanvasGroup;
    public CanvasGroup inGameMenuCanvasGroup;

    public void displayWindow()
    {
        // open tech titan inventory
        TTInventoryCanvasGroup.interactable = true;
        TTInventoryCanvasGroup.blocksRaycasts = true;
        TTInventoryCanvasGroup.alpha = 1f;
        Time.timeScale = 0f;

        // close in game menu
        inGameMenuCanvasGroup.interactable = false;
        inGameMenuCanvasGroup.blocksRaycasts = false;
        inGameMenuCanvasGroup.alpha = 0f;

        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void closeWindow()
    {
        // close tech titan inventory
        TTInventoryCanvasGroup.interactable = false;
        TTInventoryCanvasGroup.blocksRaycasts = false;
        TTInventoryCanvasGroup.alpha = 0f;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

}
