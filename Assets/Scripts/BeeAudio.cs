using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeAudio : MonoBehaviour
{
    public float detectionRadius = 5f;
    public AudioClip beebuzz;
    private AudioSource audio;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= detectionRadius)
        {
            if (!audio.isPlaying)
            {
                audio.clip = beebuzz;
                audio.Play();
            }
        }
        else
        {
            audio.Stop();
        }
    }
}