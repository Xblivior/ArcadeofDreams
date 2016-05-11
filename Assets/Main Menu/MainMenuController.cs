using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			SceneManager.LoadScene ("Overworld");
		}
	}

	public void ToMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void Controls()
	{
		SceneManager.LoadScene ("Controls");
	}
	public void Credits()
	{
		SceneManager.LoadScene ("Credits");
	}

	public void HighscoresScene()
	{
		SceneManager.LoadScene ("HighscoreScene");
	}


}


//Kotis
