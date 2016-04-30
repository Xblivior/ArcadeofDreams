using UnityEngine;
using System.Collections;

public class platformThreeSpawner : MonoBehaviour 
{
	public GameObject platformThree;

	void Start () 
	{
		Invoke ("SpawnPlatform", 0);
	}


	void Update () 
	{

	}

	void SpawnPlatform()
	{
		float spawnPointX = Random.Range (4f, 6f);
		float spawnPointY = Random.Range (-0.5f, 0f);
		Vector3 spawnPosition = new Vector3 (spawnPointX, spawnPointY, 0);
		Instantiate(platformThree, spawnPosition, Quaternion.identity);
	}
}

//Eugene