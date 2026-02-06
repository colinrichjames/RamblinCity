using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
		public float keyDelay = 1f;  // 1 second
		private float timePassed = 0f;
		void Start()
		{
			open = false;
		}

		void Update()
		{
			timePassed += Time.deltaTime;
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 3 && timePassed >= keyDelay)
					{
						if (open == false && timePassed >= keyDelay)
						{
							if (Input.GetKeyDown("e") && timePassed >= keyDelay)
							{
								StartCoroutine(opening());
							}
						}
						else
						{
							if (open == true && timePassed >= keyDelay)
							{
								if (Input.GetKeyDown("e") && timePassed >= keyDelay)
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}