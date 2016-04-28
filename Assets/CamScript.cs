using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamScript : MonoBehaviour 
{
	List <HighScoreEntry> myHighScores = new List <HighScoreEntry>();
	// Use this for initialization
	void Start () 
	{
		LoadScores();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			NewScores();
			SaveScore();
		}
	}

	void LoadScores()
	{
		for (int i = 0; i < 10; i++)
		{
			if (PlayerPrefs.HasKey("NameEntry" + i.ToString()))
			{
				myHighScores.Add(new HighScoreEntry(PlayerPrefs.GetString("NameEntry" + i.ToString()), PlayerPrefs.GetInt("ScoreEntry" + i.ToString())));

				Debug.Log (myHighScores[i].playerName + myHighScores[i].playerScore);
			}
		}
	}

	void SaveScore()
	{
		for (int i = 0; i < myHighScores.Count; i++)
		{
			PlayerPrefs.SetString ("NameEntry" + i.ToString(), myHighScores[i].playerName);
			PlayerPrefs.SetInt ("ScoreEntry" + i.ToString(), myHighScores[i].playerScore);
		}
	}

	void NewScores()
	{
		myHighScores.Add (new HighScoreEntry("John", 100));
	}
}
