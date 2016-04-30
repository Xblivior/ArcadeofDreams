using UnityEngine;
using System.Collections;

public class aiSpawn : MonoBehaviour 
{
	public GameObject AI;
	//public Material [] randomMaterials;

	void Start () 
	{
		Invoke ("Spawn", 1);
	}

	void Spawn()
	{
		float spawnPointX = Random.Range (-4.5f, 4.5f);
		float spawnPointY = 4.5f;
		Vector3 spawnPosition = new Vector3 (spawnPointX, spawnPointY, -1);
		Instantiate(AI, spawnPosition, Quaternion.identity);

	}

	void Update () 
	{
	
	}
}
