using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int damageFromBee = 1;

    public HealthBar healthBar;
    private Animator playerAnim;
    public bool enemies_chasing;
    public static bool isGodModeEnabled = false;
    //public GameObject audio_source_object;
    private AudioSource audio_source;
    //public AudioClip world_song;
    //public AudioClip fight_song;
    public CanvasGroup inGameMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //audio_source=audio_source_object.GetComponent<AudioSource>();
        playerAnim = GetComponent<Animator>();
    }

    public void set_chase(bool state)
    {
       // Debug.Log("Called set_chase with");
        ///Debug.Log(state);
       // Debug.Log(enemies_chasing);
        enemies_chasing=state;
    }
    IEnumerator playsong(AudioClip song)
    {
    
            audio_source.clip = song;
            audio_source.Play();
            yield return new WaitForSeconds(audio_source.clip.length);
       
    }

        IEnumerator playsong_fight(AudioClip song)
    {
 
            audio_source.clip = song;
            audio_source.Play();
            yield return new WaitForSeconds(audio_source.clip.length);
    
    }
    // take damage by bees
    public void TakeDamage(int damage)
    {
        if (!isGodModeEnabled)
        {
            playerAnim.SetBool("IsStung", true);
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

            //playerAnim.SetBool("IsMoving", true);
            StartCoroutine(ResetIsStung());

            if (currentHealth <= 0)
            {
                playerAnim.SetBool("IsDead", true);
                StartCoroutine(DelayedSceneLoad());
            }
        }
    }

    // take damage by bulldog roar
    public void TakeDamageByDog(int damage)
    {
        if (!isGodModeEnabled)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                playerAnim.SetBool("IsDead", true);
            }
        }
    }

    public void AddBlood(int blood)
    {
        if (!isGodModeEnabled)
        {
            currentHealth += blood;
            if (currentHealth > 100)
            {
                currentHealth = 100;
            }

            healthBar.SetHealth(currentHealth);
        }
    }

    public void BeingHit(int damage)
    {

        if (!isGodModeEnabled)
        {
            playerAnim.SetBool("IsAttacked", true);
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

            playerAnim.SetBool("IsMoving", true);
            StartCoroutine(ResetIsAttacked());
        

            if (currentHealth <= 0)
            {
                playerAnim.SetBool("IsDead", true);
                StartCoroutine(DelayedSceneLoad());
            }
        }
    }

    private IEnumerator ResetIsAttacked()
    {
        yield return new WaitForSeconds(1.0f);
        playerAnim.SetBool("IsAttacked", false);
    }

    private IEnumerator ResetIsStung()
    {
        yield return new WaitForSeconds(1.0f);
        playerAnim.SetBool("IsStung", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bee"))
        {
            TakeDamage(damageFromBee);
        }
    }
    private IEnumerator DelayedSceneLoad()
    {
        yield return new WaitForSeconds(3.0f); //change the delay time as needed
        SceneManager.LoadScene("GameMenuScene");
        Cursor.lockState = CursorLockMode.None;
    }

    public void ToggleGodMode()
    {
        // If god mode is currently enabled, disable it; otherwise, enable it
        if (isGodModeEnabled)
        {
            isGodModeEnabled = false; // Disable god mode
             if (inGameMenuCanvas.interactable)
            {
                inGameMenuCanvas.interactable = false;
                inGameMenuCanvas.blocksRaycasts = false;
                inGameMenuCanvas.alpha = 0f;
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
            }
            // If the pause menu is not interactable, show it
            else
            {
                inGameMenuCanvas.interactable = true;
                inGameMenuCanvas.blocksRaycasts = true;
                inGameMenuCanvas.alpha = 1f;
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else
        {
            isGodModeEnabled = true; // Enable god mode
             if (inGameMenuCanvas.interactable)
            {
                inGameMenuCanvas.interactable = false;
                inGameMenuCanvas.blocksRaycasts = false;
                inGameMenuCanvas.alpha = 0f;
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
            }
            // If the pause menu is not interactable, show it
            else
            {
                inGameMenuCanvas.interactable = true;
                inGameMenuCanvas.blocksRaycasts = true;
                inGameMenuCanvas.alpha = 1f;
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        inGameMenuCanvas.alpha=0;
        Time.timeScale=1f;
    }
    
}
