using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour 
{
	public GameObject gameController;

	public Rigidbody2D projectilePrefab;
	public Transform projectileSpawn;
	float timer = 0.25f;

	void Update () 
	{
		//Start Timer for Rocket Launcher
		timer -= Time.deltaTime;

		//To stop the timer going below 0
		if (timer <= 0) 
		{
			timer = 0;
		}

		if (timer <= 0)
		{
			//Spawns the GameObject once the timer is 0. Once the Gameobject is spawned the timer resets to 5.
			Rigidbody2D projectileInstance;
			projectileInstance = Instantiate (projectilePrefab, projectileSpawn.position, projectileSpawn.rotation) as Rigidbody2D;
			//resets timer to 5
			timer = 5;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		//if the thrown thing hits the goal
		if (other.gameObject.tag == "Thrown")
		{
			
			// tell the gamecontroller its a win
			gameController.GetComponent<GameController>().Victory();
			Destroy(other.gameObject);

		}
	}
		
}


//Xblivior + Eugene