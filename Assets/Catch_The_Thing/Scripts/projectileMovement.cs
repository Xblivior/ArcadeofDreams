using UnityEngine;
using System.Collections;

public class projectileMovement : MonoBehaviour 
{
	public float moveSpeed;
	public Rigidbody2D projectile;

	// Use this for initialization
	void Start () 
	{
		projectile = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () 
	{
		//Give projectile movement to move in a downward direction.
		projectile.velocity = transform.up * -moveSpeed;
	}
}
