using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour 
{
	private float moveSpeed = 6f;
	public Rigidbody2D playerChar;
	public GameObject gameController;

	void Start () 
	{
		playerChar = GetComponent<Rigidbody2D>();
	}
	

	void Update () 
	{
		//moves the player left on key press
		if (Input.GetKey(KeyCode.A))
			playerChar.velocity = transform.right * -moveSpeed;

		//stops moving the player when the key is released
		if (Input.GetKeyUp(KeyCode.A))
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;

		//moves the player right on key press
		if (Input.GetKey(KeyCode.D))
			playerChar.velocity = transform.right * moveSpeed;

		//stops moving the player when the key is released
		if (Input.GetKeyUp(KeyCode.D))
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//Loads the victory method from the gamecontroller script once collision happens with the projectile
		if (other.gameObject.tag == "CTTProjectile") 
		{
			gameController.GetComponent<CTTGameController>().Victory();
			Destroy (other.gameObject);
		}
	}
}

//Eugene