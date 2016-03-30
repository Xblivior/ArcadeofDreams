using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public Text victoryText;
	public Text failText;
	public Slider timerSlider;

	bool victory;
	bool fail;
	float timer = 3f;


	//bool victory;

	// Use this for initialization
	void Start () 
	{
		victoryText.enabled = false;
		failText.enabled = false;
		//victory = false;
		//fail = false;
	}

	// Update is called once per frame
	void Update () 
	{
		Timer();


	}

	public void Timer()
	{
		timer -= Time.deltaTime;
		timerSlider.GetComponent<Slider>().value = timer;

		if (timer <= 0f)
		{
			FailGame();
		}

	}

	public void Victory()
	{
		//victory = true;
		victoryText.enabled = true;
		//Time.timeScale = 0.05f;

		//load Overworld
		SceneManager.LoadScene ("Overworld");
	}

	public void FailGame()
	{
		//fail = true;
		failText.enabled = true;
		Time.timeScale = 0.05f;
	
	}


}

//Xblivior

