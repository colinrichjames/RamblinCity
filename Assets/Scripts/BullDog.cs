using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BullDog : MonoBehaviour
{
    //this script controls the bulldog enemy
    public int maxHealth = 100;
    public int currentHealth;
    public int damageValueToDog = 20;

    public HealthBar healthBar;
    private Animator bulldogAnim;

    public PlayerMovement pm;
    
    //public Button pinkCardButton;
    //public DisplayItem displayItem;
    public string color;
    public BulldogStatus bulldogStatus;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        bulldogAnim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        pm.ResetPunch();
        pm.ResetMeleePunch();

        if (currentHealth == 0)
        {
            //bulldogAnim.SetBool("IsRoar", false);
            //bulldogAnim.SetBool("IsSnuff", false);

            bulldogAnim.SetBool("IsDead", true);

            if (color == "fire")
            {
                bulldogStatus.DogKilled();
            }

            if (color == "albino")
            {
                bulldogStatus.DogKilled();
            }

            if (color == "ice")
            {
                bulldogStatus.DogKilled();
            }

            // if all three bull dog died, enable wood card in Maya Guide
            //if (albino.isAlbinoDied && fire.isFireDied && ice.isIceDied)
            //{
                //pinkCardButton.interactable = true;
            //    displayItem.isLocked = false;
            //}

            Destroy(this.gameObject, 5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.CompareTag("Player") && (pm.isBeingPunched || pm.isBeingMeleePunched))
        {
            Debug.Log("player");
            TakeDamage(damageValueToDog);

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Keyboard"))
        {
        Rigidbody rbdy = gameObject.GetComponent<Rigidbody>();

        //Stop Moving/Translating
        rbdy.velocity = Vector3.zero;

        //Stop rotating
        rbdy.angularVelocity = Vector3.zero;
        }
    }
}
