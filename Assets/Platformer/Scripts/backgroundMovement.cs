using UnityEngine;
using System.Collections;

public class backgroundMovement : MonoBehaviour
{
	public Transform[] Waypoints;
	public float moveSpeed;
	public int curWaypoint;
	public bool doMove = true;
	public Vector3 Target;
	public Vector3 moveDirection;
	public Vector3 Velocity;

	public Rigidbody2D background;

	void Start () 
	{
	
	}
	

	void Update () 
	{
		if(curWaypoint < Waypoints.Length)
		{
			Target = Waypoints[curWaypoint].position;
			moveDirection = Target - transform.position;
			Velocity = background.velocity;

			if(moveDirection.magnitude < 1)
			{
				curWaypoint++;
			}
			else
			{
				Velocity = moveDirection.normalized * moveSpeed;
			}
		}
		else
		{
			if(doMove)
			{
				curWaypoint=0;
			}
			else
			{
				Velocity = Vector3.zero;
			}
		}

		background.velocity = Velocity;
	}
}


//Eugene