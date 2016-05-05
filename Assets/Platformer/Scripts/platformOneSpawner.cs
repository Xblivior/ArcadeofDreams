using UnityEngine;
using System.Collections;

public class platformOneSpawner : MonoBehaviour 
{
	public GameObject platformOne;

	void Start () 
	{
		Invoke ("SpawnPlatform", 0);
	}
	

	void Update () 
	{
		
	}

	void SpawnPlatform()
	{
		float spawnPointX = Random.Range (-6f, -4f);
		float spawnPointY = Random.Range (-3.5f, -3f);
		Vector3 spawnPosition = new Vector3 (spawnPointX, spawnPointY, 0);
		Instantiate(platformOne, spawnPosition, Quaternion.identity);
	}
}

//Eugene