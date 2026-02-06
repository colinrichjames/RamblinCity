using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public CanvasGroup tutorialCanvasGroup;

    public void showTutorial()
    {
        // show instruction
        tutorialCanvasGroup.interactable = true;
        tutorialCanvasGroup.blocksRaycasts = true;
        tutorialCanvasGroup.alpha = 1f;
        //Cursor.lockState = CursorLockMode.Confined;
    }
}
