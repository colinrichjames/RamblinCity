using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class MinionAI : MonoBehaviour
{
	private Animator animator;
	
	private float ai_distance_from_moving_waypoint;
	private float ai_distance_from_player;

	[SerializeField]
	private float capture_distance;

	public GameObject[] waypoints;

	public GameObject player;

	[SerializeField]
	private float look_ahead_time;

	public int currWaypoint;
	public UnityEngine.AI.NavMeshAgent navAgent;

	private Vector3 destination; 
	private bool gizmos;

	public Transform target;
    private UnityEngine.AI.NavMeshHit hit;
    private bool blocked = false;
	//private bool cube_created=false;

	private GameObject cube;



	public enum AIState
	{
		moveStationary,
		moveAttacking
	};
	public void setAIStateStationary()
	{ 
		aistate=AIState.moveStationary;
	}

	public AIState aistate;

	private void Start()
	{ 
		animator=GetComponent<Animator>();
		navAgent=GetComponent<UnityEngine.AI.NavMeshAgent>();
		aistate=AIState.moveStationary;
		currWaypoint=-1;
		setNextWaypoint();
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
		else 
		{ 

		}


	}
	
	void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
		if(gizmos==true)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawCube(destination, new Vector3(1, 2, 1));
			
		}
    }

	private void Update() 
	{ 

	/*
		if(currWaypoint>5)
		{
			currWaypoint=0;
		}
		*/
		//animator.SetFloat("vely", navAgent.velocity.magnitude/navAgent.speed);

		//check distance again to see if the waypoint is moving
		Vector3 currentWaypointPosition = waypoints[currWaypoint].transform.localPosition;
		Vector3 originalWaypointPosition = waypoints[currWaypoint].transform.position;
		//Debug.Log("originalWaypointPosition");
		//Debug.Log(originalWaypointPosition.ToString());
		//Debug.Log("currentWaypointPosition");
		//Debug.Log(currentWaypointPosition.ToString());
		//distance between two vector
		ai_distance_from_moving_waypoint=Vector3.Distance(this.transform.position,waypoints[currWaypoint].transform.localPosition);
		ai_distance_from_player=Vector3.Distance(this.transform.position,player.transform.position);
		//get velocity of the object 
		Vector3 waypoint_velocity = waypoints[currWaypoint].GetComponent<VelocityReporter>().velocity;
		Vector3 waypoint_raw_velocity = waypoints[currWaypoint].GetComponent<VelocityReporter>().rawVelocity;
		Vector3 player_velocity = player.GetComponent<VelocityReporter>().velocity;
		Vector3 player_raw_velocity = player.GetComponent<VelocityReporter>().rawVelocity;
		//Debug.Log("AI distance from player");
		//Debug.Log(ai_distance_from_player);
		blocked = UnityEngine.AI.NavMesh.Raycast(this.transform.position, destination, out hit, UnityEngine.AI.NavMesh.AllAreas);
        Debug.DrawLine(this.transform.position, destination, blocked ? Color.red : Color.green);

        if (blocked)
            Debug.DrawRay(hit.position, Vector3.up, Color.red);


		if(ai_distance_from_player <= 5f)
		{
			aistate=AIState.moveAttacking;
		}
		else 
		{
			aistate=AIState.moveStationary;
		}

		switch(aistate)
		{
			case AIState.moveStationary:
				destination=originalWaypointPosition;
				gizmos=false;
				if(navAgent.remainingDistance<=1 && navAgent.pathPending!=true)
				{
					setNextWaypoint();
				}
				else 
				{

				}
				break;

			case AIState.moveAttacking:
				if (ai_distance_from_player<=5f)
				{
					aistate=AIState.moveAttacking;
				}
				else 
				{ 
					aistate=AIState.moveStationary;
				}
				break;
				//Debug.Log(waypoint_velocity.z);
				//Debug.Log(waypoint_raw_velocity.z);
				//Debug.Log(player_velocity.z);
				//Debug.Log(player_raw_velocity.z);
				//gizmos=true;
				// calculate the position of the target 
				
				// i Know the velocity
				// ray cast from my current position  to delta t * velocity
				/*
				// here we recalculate where to move to 
				navAgent.ResetPath();

				Vector3 predicted_destination=new Vector3(player.transform.localPosition.x + (look_ahead_time*player_velocity.x), player.transform.localPosition.y,player.transform.localPosition.z + (look_ahead_time*player_velocity.z));

				navAgent.SetDestination(predicted_destination);
				destination=predicted_destination;
				if(cube_created==false)
				{
					cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
					// Get the Renderer component from the new cube
					var cubeRenderer = cube.GetComponent<Renderer>();
					// Call SetColor using the shader property name "_Color" and setting the color to red
					cubeRenderer.material.SetColor("_Color", Color.red);
					cube.transform.position=destination;
					cube_created=true;
				}
				else 
				{
					cube.transform.position=destination;

				}
				//navAgent.RayCast(transform.position);
				/*
				if(ai_distance_from_player-capture_distance<=5)
				{
					setNextWaypoint();
					cube_created=false;
					Destroy(cube);

				}
				else 
				{

				}*/

		}

	}

}
