using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilBulldogMovement : MonoBehaviour
{
    public Transform player;
    public float snuffRadius = 10f;
    public float roarRadius = 5f;

    private Animator dogAnim;

    public Player playerHealth;
    public int roarDamage = 5;

    //private int frameCounter = 0;
    //private int framesPerUpdate = 240;
    private float nextAnimationTime;
    private float attackInterval = 5f;

    //projectile
    public GameObject dogball;
    public float shootForce;
    public int shootDamage = 20;

    // Start is called before the first frame update
    void Start()
    {
        dogAnim = GetComponent<Animator>();

        nextAnimationTime = Time.time + attackInterval;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= snuffRadius && distanceToPlayer > roarRadius) 
        {
            transform.LookAt(player);

            //frameCounter++;
            if (Time.time >= nextAnimationTime) 
            {
                //frameCounter = 0;
                StartSnuff();
                StopRoar();

                nextAnimationTime = Time.time + attackInterval;
            }
        }
        else if (distanceToPlayer <= roarRadius)
        {
            transform.LookAt(player);

            //frameCounter++;
            if (Time.time >= nextAnimationTime) 
            {
                //frameCounter = 0;
                StopSnuff();
                StartRoar();

                float randomDelay = Random.Range(10f, 20f);
                Invoke("ShootDogBall", randomDelay);

                nextAnimationTime = Time.time + attackInterval;
            }
        }
        else 
        {
            StopSnuff();
            StopRoar();
        }
    }

    private void ShootDogBall()
    {
        Vector3 dogPosition = transform.position + transform.up * 0.7f;
        GameObject ballInstance = Instantiate(dogball, dogPosition, Quaternion.identity);
        Rigidbody ballRigidbody = ballInstance.GetComponent<Rigidbody>();
        //Collider ballCollider = ballInstance.GetComponent<Collider>();
        
        if (ballRigidbody != null)
        {
                //ballCollider.enabled = true;

            Vector3 directionToPlayer = (player.position + Vector3.up * 0.8f - dogPosition).normalized;
            ballRigidbody.AddForce(directionToPlayer * shootForce, ForceMode.Impulse);

            playerHealth.BeingHit(shootDamage);
        }

        //float randomDelay = Random.Range(10f, 30f);
        //Invoke("ShootDogBall", randomDelay);
    }

    private void StartRoar() {
        dogAnim.SetBool("IsRoar", true);

        if (playerHealth != null)
        {
            playerHealth.TakeDamageByDog(roarDamage);
        }
    }

    private void StopRoar() {
        dogAnim.SetBool("IsRoar", false);
    }

    private void StartSnuff() {
        dogAnim.SetBool("IsSnuff", true);
    }

    private void StopSnuff() 
    {
        dogAnim.SetBool("IsSnuff", false);
    }
 
}
