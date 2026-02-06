using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsePesticideGun : MonoBehaviour
{
    public GameObject sprayGun;
    public bool gun_enabled = false;

    public void ClickToUse()
    {
        if (gun_enabled == false)
        {
            sprayGun.SetActive(true);
            gun_enabled = true;
        }
        else 
        {
            sprayGun.SetActive(false);
            gun_enabled=false;
        }
        
    }
}
