using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindow : MonoBehaviour
{
    public CanvasGroup MayaInventoryCanvasGroup;
    public CanvasGroup DescriptionCanvasGroup;

    public void Close()
    {
        // close maya inventory 
        MayaInventoryCanvasGroup.interactable = false;
        MayaInventoryCanvasGroup.blocksRaycasts = false;
        MayaInventoryCanvasGroup.alpha = 0f;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;

        // close inventory description
        DescriptionCanvasGroup.interactable = false;
        DescriptionCanvasGroup.blocksRaycasts = false;
        DescriptionCanvasGroup.alpha = 0f;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
