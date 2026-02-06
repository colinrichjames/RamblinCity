using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Added to include the SceneManager class

public class BossBee : MonoBehaviour
{
    //this script is for the final boss bee
    public int maxHealth = 100;
    public int currentHealth;
    public int damageValueToBee = 20;

    public HealthBar healthBar;
    private Animator beeAnim;

    public PlayerMovement pm;
    public AudioSource audio_source;
    public AudioClip song;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        beeAnim = GetComponent<Animator>();
    }

     IEnumerator LoadCreditsCoroutine()
    {
        audio_source.clip=song;
        audio_source.Play();
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(6);

        SceneManager.LoadScene("CreditScene");
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            beeAnim.SetBool("IsAttack", false);
            beeAnim.SetBool("IsDeath", true);
            Destroy(gameObject.GetComponent<SphereCollider>());
            gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
            //Destroy(this.gameObject, 7f);
            StartCoroutine(LoadCreditsCoroutine());
        }
    }
}
