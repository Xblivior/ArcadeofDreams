using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	// throwing variables
	public GameObject thrown;
	public Transform throwSpawn;

	//Variables for player movement
	public float speed;

	bool hasShot;
	float timer = 5f;

	// Use this for initialization
	void Start () 
	{
		hasShot = false;
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
		moveDirection = new Vector3(0, -hInput, 0);
		moveDirection = moveDirection * speed * Time.deltaTime;

		//move transform by that vector
		transform.Translate(moveDirection);

		//if timer <= 0
		if (timer <= 0f)
		{
			//set it to 0
			timer= 0f;
		}

		if (gameObject.tag == "TTTPlayer")
		{
			//shoot the thing
			if (Input.GetKeyDown(KeyCode.Space) && hasShot == false)
			{

				//shoot
				Instantiate(thrown, throwSpawn.transform.position, throwSpawn.transform.rotation);

				hasShot = true;
			}
		}
	}


}


//Xblivior
