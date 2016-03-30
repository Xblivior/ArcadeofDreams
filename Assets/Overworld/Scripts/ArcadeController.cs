using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ArcadeController : MonoBehaviour 
{
	public string[] nextLevel;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void NextLevel()
	{
		SceneManager.LoadScene (nextLevel[Random.Range (0, nextLevel.Length)]);
	}
}
