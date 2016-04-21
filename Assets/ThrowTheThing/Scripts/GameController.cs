﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public Text victoryText;
	public Text failText;
	public Slider timerSlider;

	public GameObject arcadePlayer;
	public GameObject arcade;

	bool victory;
	bool fail;

	bool isActive;
	float timer = 3f;


	//bool victory;

	// Use this for initialization
	void Start () 
	{
		victoryText.enabled = false;
		failText.enabled = false;
		//victory = false;
		//fail = false;

		isActive = false;
	}

	// Update is called once per frame
	void Update () 
	{
		if (isActive == true)
		{
			timer -= Time.deltaTime;
			Debug.Log (timer);
			timerSlider.GetComponent<Slider>().value = timer;
		}

		if (timer <= 0f)
		{
			FailGame();
		}
	}

	public void Victory()
	{
		//victory = true;
		//show Win Text
		victoryText.enabled = true;

		//tell arcade to do Win()
		arcade.GetComponent<ArcadeController>().Win();

		//disable minigame player controller
		arcadePlayer.GetComponent<PlayerController>().enabled = false;

	}

	public void FailGame()
	{
		//fail = true;
		//show Lose text
		failText.enabled = true;

		//tell arcade to do  Lose()
		arcade.GetComponent<ArcadeController>().Lose();

		//disable minigame player controller
		arcadePlayer.GetComponent<PlayerController>().enabled = false;
	
	}

	public void ActivateGame()
	{
		//start randomiser
		gameObject.GetComponent<Randomiser>().enabled = true;

		//enable minigame player controller
		arcadePlayer.GetComponent<PlayerController>().enabled = true;

		//start timer
		isActive = true;

	}
		
}

//Xblivior

