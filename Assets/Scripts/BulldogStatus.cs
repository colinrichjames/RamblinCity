using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulldogStatus : MonoBehaviour
{
    public DisplayItem displayItem;
    public int NumberOfDogDied { get; private set;}
    public UnityEvent<BulldogStatus> OnDogKilled;

    public void DogKilled() 
	{ 
		NumberOfDogDied++;
        OnDogKilled.Invoke(this);
        Debug.Log(NumberOfDogDied);
        
        if (NumberOfDogDied == 3)
        {
            displayItem.isLocked = false;
        }
	}
}
