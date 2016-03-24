using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CTTGameController : MonoBehaviour 
{
	public Text victoryText;

	void Start ()
	{
		victoryText.enabled = false;
	}
	

	void Update ()
	{
	
	}

	public void Victory()
	{
		victoryText.enabled = true;
	}
}
