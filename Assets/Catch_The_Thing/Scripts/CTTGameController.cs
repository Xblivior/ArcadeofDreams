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
		victoryText.enabled = false;
		defeatText.enabled = false;
	}
	

	void Update ()
	{
	
	}

	public void Victory()
	{
		victoryText.enabled = true;

		//load Overworld
		SceneManager.LoadScene ("Overworld");
	}

	public void Defeat()
	{
		defeatText.enabled = true;
	}
}
