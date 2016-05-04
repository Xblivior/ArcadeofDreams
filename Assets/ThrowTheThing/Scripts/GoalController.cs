using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour 
{
	public GameObject gameController;

	public GameObject cTTProjectile;
	public Transform projectileSpawn;
	float timer = 0.5f;

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
			Instantiate(cTTProjectile, projectileSpawn.transform.position, Quaternion.identity);
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


//Xblivior