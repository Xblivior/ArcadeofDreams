using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class platformerGameController : MonoBehaviour 
{
	//game state canvas refereneces 
	public Text timerText;

	//get timer
	public float timer = 8f;


	void Start () 
	{

	}


	void Update () 
	{
		//start timer
		timer -= Time.deltaTime;

		//and round it to nearest second
		int seconds = Mathf.RoundToInt(timer);

		//show countdown 
		timerText.text = "Timer: " + seconds + "sec";
	}
}