﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseScreenCOntroller : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
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
