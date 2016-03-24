using UnityEngine;
using System.Collections;

public class projectileSpawner : MonoBehaviour 
{
	public Rigidbody projectilePrefab;
	public Transform projectileSpawn;
	float timer = 0.5f;

	void Start () 
	{
	
	}
	

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
			Rigidbody projectileInstance;
			projectileInstance = Instantiate (projectilePrefab, projectileSpawn.position, projectileSpawn.rotation) as Rigidbody;
			timer = 5;
		}
	}
}
