﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControllerO : MonoBehaviour 
{
	public GameObject[] arcadeMachines;
	public LayerMask arcadeLayer;
	bool flag = false;

	public int maxHappiness = 100;
	public int currentHappiness;
	public Slider happinessBar;

	public Text scoreTex;
	public static int score;

	// Use this for initialization
	void Start () 
	{
		SpawnArcades();
		currentHappiness = maxHappiness;
		happinessBar.maxValue = maxHappiness;
		happinessBar.minValue = 0f;
		happinessBar.wholeNumbers = true;

		score = 0;

	}
	
	// Update is called once per frame
	void Update () 
	{
		happinessBar.value = currentHappiness; 
		//scoreTex.text = "Score: " + score;
	}


	//NOTE: Make timer for while loop. IEnumerator? with random.range countdown timer 
	void SpawnArcades()
	{
		//variables
		Vector2 randomPos = new Vector2();
		flag = false;

		while (!flag)
		{
			//get random spot
			randomPos += Random.insideUnitCircle * 5;

			//pick a spot
			Vector3 possibleSpot = new Vector3 (randomPos.x, 1.5f, randomPos.y);

			// if spot is good (if there is nothing in the check)
			if (!Physics.CheckSphere(possibleSpot, 3f, arcadeLayer))
			{
				//set flag = true
				flag = true;
				//spawn random arcade machine
				Instantiate(arcadeMachines[Random.Range(0, arcadeMachines.Length)], possibleSpot, Quaternion.identity);
			}

		}

		Invoke("SpawnArcades",5f);
		
	}

	public void Happiness (int happiness)
	{
		currentHappiness += happiness;
	}

	public void Sadness (int sadness)
	{
		currentHappiness -= sadness;
	}
}


//Xblivior
