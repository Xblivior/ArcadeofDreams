using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour 
{
	private float moveSpeed = 5f;
	public Rigidbody2D playerChar;

	void Start () 
	{
		playerChar = GetComponent<Rigidbody2D>();
	}
	

	void Update () 
	{
		if (Input.GetKey(KeyCode.A))
			playerChar.velocity = transform.right * -moveSpeed;
		
		if (Input.GetKeyUp(KeyCode.A))
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		if (Input.GetKey(KeyCode.D))
			playerChar.velocity = transform.right * moveSpeed;

		if (Input.GetKeyUp(KeyCode.D))
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
	}
}
