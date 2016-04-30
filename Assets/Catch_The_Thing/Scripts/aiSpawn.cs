using UnityEngine;
using System.Collections;

public class aiSpawn : MonoBehaviour 
{
	public GameObject AI;
	//public Material [] randomMaterials;

	void Start () 
	{
		//Calls "Spawn()"
		Invoke ("Spawn", 1);
	}

	void Spawn()
	{
		//Spawns the AI at a Random range along the X axis between 2 points
		float spawnPointX = Random.Range (-4.5f, 4.5f);
		//Spawns the AI at a fixed Position along the Y axis
		float spawnPointY = 3.5f;
		//Creates a spawn position along the x and Y axis and spawns the AI.
		Vector3 spawnPosition = new Vector3 (spawnPointX, spawnPointY, -1);
		Instantiate(AI, spawnPosition, Quaternion.identity);

	}

	void Update () 
	{
	
	}
}

//Eugene
