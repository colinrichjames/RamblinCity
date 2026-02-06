using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GettingInAndOutOfCar : MonoBehaviour
{
    [Header ("Camera")]
    [SerializeField] CinemachineVirtualCamera autoCam = null;
    [SerializeField] CinemachineFreeLook mainCam = null;

    
    [Header ("Human")]
    [SerializeField] GameObject human = null;
    [SerializeField] float closeDistance = 10f;

    [Space, Header ("Car Stuff")]
    [SerializeField] GameObject car = null;
    [SerializeField] CarController carController;
    [SerializeField] float exitOffsetDistance = 5.0f; // Adjust this value as needed
    [Header("Input")]
    [SerializeField] KeyCode enterExitKey = KeyCode.E;
   

    [SerializeField] bool inCar = false;
    // Start is called before the first frame update
    void Start()
    {
        //inCar = car.activeSelf;
        // Deactivate main camera
        if (mainCam != null)
            mainCam.gameObject.SetActive(true); //ensures main camera is active
        else
            Debug.LogWarning("Main Cinemachine Virtual Camera reference is missing!");

        // Activate autoCam
        if (autoCam != null)
            autoCam.gameObject.SetActive(false); //ensure autocam is deactivated
        else
            Debug.LogWarning("Auto Cinemachine Virtual Camera reference is missing!");
        // Deactivate car controller
        if (carController != null)
        {
            carController.enabled = false;
        }
        else
        {
            Debug.LogWarning("Car Controller reference is missing!");
        }

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(enterExitKey))
        {
            if (inCar)
                GetOutOfCar();
            else
                GetIntoCar();
        }

    // Update the person's position based on the car if they are not in the car
    //if (!inCar && car != null)
    //{
        //human.transform.position = car.transform.position;
    //}
}
   void GetOutOfCar()
    {
        inCar = false;
        human.SetActive(true);
        carController.enabled = false;
        carController.StopCar(); // Call a method in CarController to stop the car
         // Calculate the exit position to the left of the car
        //Vector3 exitPosition = car.transform.position - car.transform.right * exitOffsetDistance;
        //Vector3 exitPosition = car.transform.position + car.transform.forward * exitOffsetDistance;
        human.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left);
         // Set the human's position
        //human.transform.position = exitPosition;
        //human.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left);
        human.transform.parent = null;
        // Deactivate autoCam
        if (autoCam != null)
            autoCam.gameObject.SetActive(false);
        else
            Debug.LogWarning("Auto Cinemachine Virtual Camera reference is missing!");

        // Activate mainCam
        if (mainCam != null)
            mainCam.gameObject.SetActive(true);
        else
            Debug.LogWarning("Main Cinemachine Virtual Camera reference is missing!");

    }

    void GetIntoCar()
    {
        float distanceToCar = Vector3.Distance(human.transform.position, car.transform.position);
        
        if (distanceToCar <= closeDistance)
        {
            inCar = true;
            human.SetActive(false);
            human.transform.parent = car.transform;

            // Activate car controller
            if (carController != null)
            {
                carController.enabled = true;
            }
            else
            {
                Debug.LogWarning("Car Controller reference is missing!");
            }

            // Activate autoCam
            if (autoCam != null)
                autoCam.gameObject.SetActive(true);
            else
                Debug.LogWarning("Auto Cinemachine Virtual Camera reference is missing!");

            // deactivate mainCam
            if (mainCam != null)
                mainCam.gameObject.SetActive(false);
            else
                Debug.LogWarning("Main Cinemachine Virtual Camera reference is missing!");
            
        }
    }
}

