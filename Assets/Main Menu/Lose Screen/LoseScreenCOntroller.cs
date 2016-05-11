using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseScreenCOntroller : MonoBehaviour 
{
	public float timer;
	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.None; 
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void MainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
