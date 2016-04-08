using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ArcadeController : MonoBehaviour 
{
	public string[] nextLevel;
	public GameObject gameController;

	// Use this for initialization
	void Start () 
	{
		gameController = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void NextLevel()
	{
		SceneManager.LoadScene (nextLevel[Random.Range (0, nextLevel.Length)]);
	}

	public void WinOrLose()
	{
		float randomNum = Random.Range (1f, 10f);

		if (randomNum <= 5f)
		{
			Win();
		}
		else if (randomNum > 5f)
		{
			Lose();
		}
	}

	void Win()
	{
		
		gameController.GetComponent<GameControllerO>().Happiness(5);
		//gameController.GetComponent<GameControllerO>().s
		Destroy(this.gameObject);

	}

	void Lose()
	{
		
		gameController.GetComponent<GameControllerO>().Sadness(5);
		Destroy(this.gameObject);

	}
		
}
