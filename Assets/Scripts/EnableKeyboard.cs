using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnableKeyboard : MonoBehaviour
{
    //this script enables the keyboard for tech titan
    public bool kb_enabled = false;
	public GameObject keyboard;

    public void ClickToUse()
    {
        if (kb_enabled == false)
        { 
            keyboard.SetActive(true);
            kb_enabled=true;
        }
        else
        { 
            keyboard.SetActive(false);
            kb_enabled=false;
        }
    }
}
