using UnityEngine;
using System.Collections;


public class playerController : MonoBehaviour 
{

	public Rigidbody2D playerChar;
	public float moveSpeed;
	public Vector2 jumpHeight;

	private bool canJump = false;


	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		CheckJump();

		if (Input.GetKey(KeyCode.A))
			playerChar.velocity = transform.right * -moveSpeed;

		if (Input.GetKeyUp(KeyCode.A))
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		if (Input.GetKey(KeyCode.D))
			playerChar.velocity = transform.right * moveSpeed;

		if (Input.GetKeyUp(KeyCode.D))
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		if (canJump = true && Input.GetKey (KeyCode.Space))
		{
			playerChar.AddForce (new Vector2(0, 1), ForceMode2D.Impulse);
			canJump = false;
		}
	}

	void CheckJump()
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position, -transform.up, out hit, 0.5f))
			{
			Debug.DrawRay(transform.position, -transform.up, Color.red);
			if (hit.transform.tag == "PlatformerGround")
				{
					canJump = true;
				}
			else if (hit.transform.tag != "PlatformerGround")
				{
					canJump = false;
				}
			}
	}
}
