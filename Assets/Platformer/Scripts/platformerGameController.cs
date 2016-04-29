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
		if (timer <= 0)
			timer = 0;

		//and round it to nearest second
		int seconds = Mathf.RoundToInt(timer);

		//show countdown 
		timerText.text = "Timer: " + seconds + "sec";
	}
}