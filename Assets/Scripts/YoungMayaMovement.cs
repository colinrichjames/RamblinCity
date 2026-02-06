using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class YoungMayaMovement : MonoBehaviour
{
    //this script is for the maya wong character
    private Animator anim;

    public Transform player;
    public float detectionRadius = 20f;
    public float stoppingDistance = 2f;
    public float walkingSpeed = 2f;

    public int frameCounter = 0;
    public int framesPerUpdate = 240;

    private bool isStopped = false;

    public GameObject dialoguePanel; 
    // inventory
    public CanvasGroup inventoryCanvasGroup;

    public float questDistance = 300f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        dialoguePanel.SetActive(false);
        questDistance = Vector3.Distance(transform.position, player.position);
        questDistance = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        questDistance = Vector3.Distance(transform.position, player.position);
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (!isStopped)
        {
            if (distanceToPlayer <= detectionRadius && distanceToPlayer > stoppingDistance) 
            {
                frameCounter++;
                if (frameCounter >= framesPerUpdate)
                {
                    anim.SetBool("IsPlayerClose", true);
                    Vector3 directionToPlayer = (player.position - transform.position).normalized;

                    /*
                    if (distanceToPlayer > stoppingDistance) {
                        transform.Translate(directionToPlayer * walkingSpeed * Time.deltaTime);

                        anim.SetFloat("InputMagnitude", 0f);
                        anim.SetFloat("InputMagnitude", 0.4f);
                        anim.SetFloat("InputMagnitude", 1f);
                    } 
                    */

                    transform.LookAt(player);


                }
            } 
            else if (distanceToPlayer < stoppingDistance)
            {
                isStopped = true;
                anim.SetBool("IsPlayerClose", false);

                dialoguePanel.SetActive(true);
            }   
        } else {
            //Debug.Log("Maya stopped");
            // if Maya is stopped, recheck the distance again
            if (distanceToPlayer <= detectionRadius) 
            {
                if (inventoryCanvasGroup.alpha == 0f)
                {
                    dialoguePanel.SetActive(true);
                } 
            }
            else {
                dialoguePanel.SetActive(false);
            }
        }
    }

}