using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class BeeMovement : MonoBehaviour
{
    //this script provides the movement for the bees
    public Transform player;
    public float detectionRadius = 10f;
    public float movingSpeed = 2f;
    public float stoppingDistance = 1.5f;

    //public MinionAI aiscript;

    private Animator beeAnim;
    private bool isPlayerClose = false;

    public Player playerHealth;
    public int attackDamage = 10;

    //AI Nav agent script 
	private float ai_distance_from_moving_waypoint;
	private float ai_distance_from_player;

	public GameObject[] waypoints;

	public int currWaypoint = -1;
	private UnityEngine.AI.NavMeshAgent navAgent;

	private Vector3 destination; 
	private bool gizmos;

    private UnityEngine.AI.NavMeshHit hit;
    private bool blocked = false;
    private float nextAnimationTime;
    private float attackInterval = 5f;
    public GameObject audio_source_object;
    private bool setonce=false;
 

    // Start is called before the first frame update
    void Start()
    {
        beeAnim = GetComponent<Animator>();
        //aiscript = GetComponent<MinionAI>();
        navAgent=GetComponent<UnityEngine.AI.NavMeshAgent>();
		currWaypoint=-1;
		setNextWaypoint();
        //audio_source=audio_source_object.GetComponent<AudioSource>();
        nextAnimationTime = Time.time + attackInterval;
        

    }

    private void setNextWaypoint()
	{ 

		if (currWaypoint>=5)
		{ 
			currWaypoint=0;
		}
		else 
		{ 
			currWaypoint +=1;
		}

		if(waypoints.Length!=0)
		{
		    
			navAgent.SetDestination(waypoints[currWaypoint].transform.position);
		}

	}

    private void StartAttacking() 
    {   //Debug.Log("In Start Attacking");
        beeAnim.SetBool("IsAttack", true);
        playerHealth.set_chase(true);
    }
    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        Vector3 currentWaypointPosition = waypoints[currWaypoint].transform.localPosition;
		Vector3 originalWaypointPosition = waypoints[currWaypoint].transform.position;
        ai_distance_from_moving_waypoint=Vector3.Distance(this.transform.position,waypoints[currWaypoint].transform.localPosition);
		ai_distance_from_player=Vector3.Distance(this.transform.position,player.transform.position);
        blocked = UnityEngine.AI.NavMesh.Raycast(this.transform.position, destination, out hit, UnityEngine.AI.NavMesh.AllAreas);
        Debug.DrawLine(this.transform.position, destination, blocked ? Color.red : Color.green);

        if (blocked)
        { 
            Debug.DrawRay(hit.position, Vector3.up, Color.red);
        }

        if (distanceToPlayer <= detectionRadius) 
        {
            isPlayerClose = true;
            beeAnim.SetBool("IsMoving", true);
        }
        else 
        {
           isPlayerClose = false;
           // aiscript.setAIStateStationary();
           beeAnim.SetBool("IsMoving", false);
        }

        if (isPlayerClose)
        {
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            
            if (distanceToPlayer > stoppingDistance) {
                //Debug.Log("bee should moving towards player");
                transform.Translate(directionToPlayer * movingSpeed * Time.deltaTime);
                // keep the bees in formation
                //transform.position = formationPositions[transform.GetSiblingIndex()];
            }
            else 
            {
                //Debug.Log("bee should stopped");
                beeAnim.SetBool("IsMoving", false);
            }

            // make bee's front face towards the player
            transform.LookAt(player);
            
            //frameCounter++;
            if (Time.time >= nextAnimationTime) 
            {
                //frameCounter = 0;
                //Debug.Log("bee start attacking");
                StartAttacking();
                nextAnimationTime = Time.time + attackInterval;
            }

        }
        else
        {
            StopAttacking();
            destination=originalWaypointPosition;
            
			if(navAgent.remainingDistance<=1 && navAgent.pathPending!=true)
			{
                playerHealth.set_chase(false);
				setNextWaypoint();
                

			}
        }
        
    }
    private void StopAttacking() {
        beeAnim.SetBool("IsAttack", false);
        //playerHealth.set_chase(false);
        //(playsong(world_song));
    }

}