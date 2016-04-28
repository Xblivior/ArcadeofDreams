using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

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

	public Image realityPic1;
	public Image realityPic2;
	public Image realityPic3;
	public Image realityPic4;

	public Sprite[] realityImage; 

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


	}
	
	// Update is called once per frame
	void Update () 
	{
		happinessBar.value = currentHappiness; 
		scoreTex.text = "Score: " + currentScore;
		//highScoreTex.text = PlayerPrefs.GetInt ("HighScore");

		if (currentHappiness <= 0f)
		{
			GameOver();
			/*playerprefs
			if (currentScore > PlayerPrefs.GetInt ("Highscore")) 
			{
				PlayerPrefs.SetInt ("Highscore");
			}*/
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
		if (currentHappiness <= 75f)
		{
			realityPic1.enabled = true;
			Sprite randomPic = realityImage[Random.Range(0, realityImage.Length)];
			realityPic1.GetComponent<Image>().sprite = randomPic;
		}
	}

	public void Sadness (float sadness)
	{
		currentHappiness = Mathf.Clamp(currentHappiness - sadness, 0f, 100f);
	}

	public void Score(int score)
	{
		currentScore += score;
	}

	public void GameOver()
	{
		SceneManager.LoadScene ("LoseScreen");
	}
}


//Xblivior
