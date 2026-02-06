using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource Footsteps_Gravel_Run_01;


    void Update()
    {
       

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            Footsteps_Gravel_Run_01.enabled = true;
        }
        else
        {
            Footsteps_Gravel_Run_01.enabled = false;

        }
    }
}