using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //this script shows tech titan's health as a health bar
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        if (!Player.isGodModeEnabled)
        {
            fill.color = gradient.Evaluate(slider.normalizedValue);
        }
        else
        {
            fill.color = Color.blue;
        }
        
    }

    public void Update()
    { 
        
         if (Player.isGodModeEnabled && this.gameObject.name=="Player Health Bar")
        {
            fill.color = Color.blue;
        }
        else
        {
            fill.color = gradient.Evaluate(slider.normalizedValue);
        }

    }
}
