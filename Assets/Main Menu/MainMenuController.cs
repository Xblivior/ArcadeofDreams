using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.None; 
		Cursor.visible = true; 
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

	public void Play()
	{
		SceneManager.LoadScene ("Overworld");
	}

	public void References()
	{
		SceneManager.LoadScene ("References");
	}

	public void Quit()
	{
		Application.Quit ();
	}


}


//Kotis
