using UnityEngine;
using System.Collections;

public class projectileMovement : MonoBehaviour 
{
	public float moveSpeed;
	public Rigidbody projectile;

	// Use this for initialization
	void Start () 
	{
		projectile = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
	{
		//Give projectile movement to move in a downward direction.
		projectile.velocity = transform.up * -moveSpeed;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject) 
		{
			Destroy (this.gameObject);
		}
	}
}
