using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuToggle : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        // Attempt to get the CanvasGroup component attached to this GameObject
        canvasGroup = GetComponent<CanvasGroup>();

        // Check if the CanvasGroup component is found, otherwise log an error
        if (canvasGroup == null)
        {
            Debug.LogError("PauseMenuToggle: CanvasGroup component not found!");
        }
    }

    private void Update()
    {
        // Check for the Escape key to toggle the pause menu
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // If the pause menu is currently interactable, hide it
            if (canvasGroup.interactable)
            {
                canvasGroup.interactable = false;
                canvasGroup.blocksRaycasts = false;
                canvasGroup.alpha = 0f;
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
            }
            // If the pause menu is not interactable, show it
            else
            {
                canvasGroup.interactable = true;
                canvasGroup.blocksRaycasts = true;
                canvasGroup.alpha = 1f;
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        //will want to replace input.getkeyup with Input.GetButtonUp() so that the game controller works with the game 
    }

}
