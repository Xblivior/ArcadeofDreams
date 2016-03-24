using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
	}

	public void Defeat()
	{
		defeatText.enabled = true;
	}
}
