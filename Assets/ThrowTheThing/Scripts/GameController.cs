using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public Text victoryText;

	//bool victory;

	// Use this for initialization
	void Start () 
	{
		victoryText.enabled = false;
		//victory = false;
	}

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Victory()
	{
		//victory = true;
		victoryText.enabled = true;
		Time.timeScale = 0.5f;
	}
}

