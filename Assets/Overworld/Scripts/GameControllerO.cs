﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameControllerO : MonoBehaviour 
{
	public GameObject[] arcadeMachines;
	public LayerMask arcadeLayer;
	bool flag = false;

	public float maxHappiness = 100;
	public float currentHappiness;
	public Slider happinessBar;

	public Text scoreTex;
	public int score;
	public int currentScore;

	public Text pauseText;
	bool isPaused = false;


	public Image realityPic1;

	public Animator realityPicAnim;

	public Sprite[] realityImage; 

	public GameObject playerO;


	int highscore;
	// Use this for initialization
	void Start () 
	{
		//Start Spawning Arcades
		SpawnArcades();

		//Set variables
		currentHappiness = maxHappiness;
		happinessBar.maxValue = maxHappiness;
		happinessBar.minValue = 0f;
		happinessBar.wholeNumbers = true;
		currentScore = 0;

		pauseText.enabled = false;


	}
	
	// Update is called once per frame
	void Update () 
	{
		happinessBar.value = currentHappiness; 
		scoreTex.text = "Score: " + currentScore;
		//highScoreTex.text = PlayerPrefs.GetInt ("HighScore");

		//if happiness reaches 0
		if (currentHappiness <= 0f)
		{
			//gameover
			GameOver();
		
		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			if (isPaused == true)
			{
				Time.timeScale = 1.0f;
				pauseText.enabled = false;
				isPaused = false;
			}

			else
			{
				pauseText.enabled = true;
				isPaused = true;
				Time.timeScale = 0.0f;
			}
		}

		if (isPaused == true && Input.GetKeyDown(KeyCode.M))
		{
			Time.timeScale = 1.0f;
			isPaused = false;
			SceneManager.LoadScene ("MainMenu");
		}

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
			randomPos += Random.insideUnitCircle * 10;

			//pick a spot
			Vector3 possibleSpot = new Vector3 (randomPos.x, 1.98f, randomPos.y);

			// if spot is good (if there is nothing in the check)
			if (!Physics.CheckSphere(possibleSpot, 6f, arcadeLayer))
			{
				//set flag = true
				flag = true;
				//spawn random arcade machine
				Instantiate(arcadeMachines[Random.Range(0, arcadeMachines.Length)], possibleSpot, Quaternion.identity);
			}

		}

		Invoke("SpawnArcades", 3f);

	}

	public void Happiness (float happiness)
	{
		currentHappiness = Mathf.Clamp(currentHappiness + happiness, 0f, 100f);

	}

	public void Sadness (float sadness)
	{
		if (currentHappiness > 75f && currentHappiness - sadness <= 75f)
		{
			Sprite randomPic = realityImage[Random.Range(0, realityImage.Length)];
			realityPic1.GetComponent<Image>().sprite = randomPic;
			realityPicAnim.SetTrigger("PlayFade1");

		}

		if (currentHappiness > 50f && currentHappiness - sadness <= 50f)
		{
			Sprite randomPic = realityImage[Random.Range(0, realityImage.Length)];
			realityPic1.GetComponent<Image>().sprite = randomPic;
			realityPicAnim.SetTrigger("PlayFade2");

		}

		if (currentHappiness > 25f && currentHappiness - sadness <= 25f)
		{
			Sprite randomPic = realityImage[Random.Range(0, realityImage.Length)];
			realityPic1.GetComponent<Image>().sprite = randomPic;
			realityPicAnim.SetTrigger("PlayFade3");

		}

		if (currentHappiness > 15f && currentHappiness - sadness <= 15f)
		{
			Sprite randomPic = realityImage[Random.Range(0, realityImage.Length)];
			realityPic1.GetComponent<Image>().sprite = randomPic;
			realityPicAnim.SetTrigger("PlayFade4");

		}

		currentHappiness = Mathf.Clamp(currentHappiness - sadness, 0f, 100f);

	}

	public void Score(int score)
	{
		currentScore += score;
	}

	public void GameOver()
	{
		PlayerPrefs.SetInt ("RecentScore", currentScore);
		playerO.GetComponent<FirstPersonController>().enabled = false;
		SceneManager.LoadScene ("LoseScreen");
	}
}


//Xblivior
