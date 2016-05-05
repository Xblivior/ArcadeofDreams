﻿using UnityEngine;
using System.Collections;

public class platformTwoSpawner : MonoBehaviour
{
	public GameObject platformTwo;

	void Start () 
	{
		Invoke ("SpawnPlatform", 0);
	}


	void Update () 
	{

	}

	void SpawnPlatform()
	{
		float spawnPointX = Random.Range (-0.5f, 1.0f);
		float spawnPointY = Random.Range (-2.0f, -1.0f);
		Vector3 spawnPosition = new Vector3 (spawnPointX, spawnPointY, 0);
		Instantiate(platformTwo, spawnPosition, Quaternion.identity);
	}
}

//Eugene