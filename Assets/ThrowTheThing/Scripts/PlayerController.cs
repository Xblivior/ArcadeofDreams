using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	// throwing variables
	public GameObject thrown;
	public Transform throwSpawn;

	//Variables for player movement
	public float speed;
	public float xMin, xMax, yMin, yMax;

	float timer = 5f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//make a timer
		timer -= Time.deltaTime;

		//get input from keyboard
		float hInput;
		hInput = Input.GetAxis("Horizontal");

		//turn that input into directional vector
		Vector3 moveDirection;
		moveDirection = new Vector3(hInput, 0, 0);
		moveDirection = moveDirection * speed * Time.deltaTime;

		//move transform by that vector
		transform.Translate(moveDirection);

		//Get map boundary
		GetComponent<Rigidbody2D>().position = new Vector2
			( 
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.x, xMin, xMax),
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.y, yMin, yMax)
			);

		//if timer <= 0
		if (timer <= 0f)
		{
			//set it to 0
			timer= 0f;
		}

		//shoot the thing
		if (Input.GetKeyDown(KeyCode.Space) && timer > 0f)
		{
			Instantiate(thrown, throwSpawn.transform.position, throwSpawn.transform.rotation);

			//make the timer 0
			timer = 0f;
		}
	}


}


//Xblivior
