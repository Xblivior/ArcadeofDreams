using UnityEngine;
using System.Collections;


public class playerController : MonoBehaviour 
{
	public GameObject gameController;

	public Rigidbody2D playerChar;
	public float moveSpeed;
	public Vector2 jumpHeight;

	public float maxSpeed = 5f;

	private bool canJump = false;


	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		//CheckJump();

		if (canJump = true && Input.GetKeyDown (KeyCode.Space))
		{
			playerChar.AddForce (new Vector2(0, 7), ForceMode2D.Impulse);
			canJump = false;
		}
	}

	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.A))
		{
			playerChar.AddForce (Vector3.right * -moveSpeed);
			if(playerChar.velocity.magnitude > maxSpeed)
			{
				playerChar.velocity = playerChar.velocity.normalized * maxSpeed;
			}
		}
			
		if (Input.GetKey(KeyCode.D))
		{
			playerChar.AddForce (Vector2.right * moveSpeed);
			if(playerChar.velocity.magnitude > maxSpeed)
			{
				playerChar.velocity = playerChar.velocity.normalized * maxSpeed;
			}
		}
	}
//	void CheckJump()
//	{
//		RaycastHit hit;
//		if (Physics.Raycast(transform.position, -transform.up, out hit, 1))
//			{
//			Debug.DrawRay(transform.position, -transform.up, Color.red);
//			if (hit.transform.tag == "PlatformerGround")
//			{
//				canJump = true;
//			}
//			else if (hit.transform.tag != "PlatformerGround")
//			{
//				canJump = false;
//			}
//		}
//	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "PlatformerThirdPlat")
		{
			Debug.Log("something");
			gameController.GetComponent<platformerGameController>().Success();
		}

	}
}

//Eugene
