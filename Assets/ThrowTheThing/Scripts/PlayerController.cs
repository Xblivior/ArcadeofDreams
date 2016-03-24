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

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//get input from keyboard
		float hInput;
		hInput = Input.GetAxis("Horizontal");
		float vInput;
		vInput = Input.GetAxis("Vertical");

		//turn that input into directional vector
		Vector3 moveDirection;
		moveDirection = new Vector3(hInput, 0, vInput);
		moveDirection = moveDirection * speed * Time.deltaTime;

		//move transform by that vector
		transform.Translate(moveDirection);

		//Get map boundary
		GetComponent<Rigidbody>().position = new Vector3
			( 
				Mathf.Clamp (GetComponent<Rigidbody>().position.x, xMin, xMax),
				Mathf.Clamp (GetComponent<Rigidbody>().position.y, yMin, yMax),
				0.0f
			);

		//shoot the thing
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(thrown, throwSpawn.transform.position, throwSpawn.transform.rotation);
		}
	}


}
