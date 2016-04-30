using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CTTGameController : MonoBehaviour 
{
	public Text victoryText;
	public Text defeatText;

	void Start ()
	{
		//disables Text from showing on startup and during play unless called
		victoryText.enabled = false;
		defeatText.enabled = false;
	}
	

	void Update ()
	{
	
	}

	public void Victory()
	{
		//Displays victory text
		victoryText.enabled = true;

		//load Overworld
		SceneManager.LoadScene ("Overworld");
	}

	public void Defeat()
	{
		//Displays defeat text
		defeatText.enabled = true;
	}
}

//Eugene