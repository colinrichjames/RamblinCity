using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeEnrageScript : MonoBehaviour
{
	Animator m_animator;

	void Awake()
	{
		m_animator = this.gameObject.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider c)
	{
		if(m_animator==null)
		{
			Debug.LogError("I dont have an animator!!!");
		}

		//Debug.Log("I am colliding with the tree");
		m_animator.SetTrigger("OnCollision");
		m_animator.ResetTrigger("NotColliding");
	}

	void OnTriggerExit(Collider c)
	{
		if(m_animator==null)
		{
			Debug.LogError("I dont have an animator!!!");
		}
		m_animator.ResetTrigger("OnCollision");
		//Debug.Log("I am not colliding with the tree anymore");
		m_animator.SetTrigger("NotColliding");

		

	}
  
}
