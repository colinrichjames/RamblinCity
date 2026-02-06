using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Added to include the SceneManager class

public class GameStarterMain : MonoBehaviour
{
    // Public method to start the game by loading the original interactive scene
    public void StartGame()
    {
        
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

