using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBeeMovement : MonoBehaviour
{
    public Transform player;
    public float detectionRadius = 20f;

    private Animator beeAnim;

    public Player playerHealth;
    public int attackDamage = 5;
    public int damageDamage = 10;

    // add a timer
    public float waypointChangeDelay = 5f;
    private float timer = 0f;
    private bool timeStarted = false;
    // add a timer


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
    private float attackInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        beeAnim = GetComponent<Animator>();
        navAgent=GetComponent<UnityEngine.AI.NavMeshAgent>();
		currWaypoint=-1;
		setNextWaypoint();

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
            transform.LookAt(player);

            if (!timeStarted)
            {
                timer = 0f;
                timeStarted = true;
            }

            timer += Time.deltaTime;

            if (timer >= waypointChangeDelay)
            {
                timeStarted = false;
                setNextWaypoint();
            }
            else 
            {
                //frameCounter++;
                if (Time.time >= nextAnimationTime) 
                {
                    StartAttacking();
                    nextAnimationTime = Time.time + attackInterval;
                }

                if (Time.time >= 2 * nextAnimationTime)
                {
                    //frameCounter = 0;
                    StartDamage();
                }
            }
        }
        else 
        {
            StopAttacking();
            StopDamage();
            destination=originalWaypointPosition;
			if(navAgent.remainingDistance<=1 && navAgent.pathPending!=true)
			{
				setNextWaypoint();
			}

        }
    }

    private void StartAttacking() {
        beeAnim.SetBool("IsAttack", true);

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }

    private void StopAttacking() {
        beeAnim.SetBool("IsAttack", false);
    }

    private void StartDamage() {
        beeAnim.SetBool("IsDamage", true);

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageDamage);
        }
    }

    private void StopDamage() 
    {
        beeAnim.SetBool("IsDamage", false);
    }
 

}