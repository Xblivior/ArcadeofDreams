using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class ArcadeController : MonoBehaviour 
{
	public string[] nextLevel;
	public GameObject gameController;
	public GameObject playerO;
	public Camera arcadeCam;


	// Use this for initialization
	void Start () 
	{
		gameController = GameObject.FindGameObjectWithTag("GameController");
		playerO = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void NextLevel()
	{
		//SceneManager.LoadScene (nextLevel[Random.Range (0, nextLevel.Length)]);
	}

/*	public void WinOrLose()
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
*/

	public void StartGameCam()
	{
		arcadeCam.GetComponent<GameController>().ActivateGame();
	}

	public void Win()
	{
		
		gameController.GetComponent<GameControllerO>().Happiness(5);
		playerO.GetComponent<FirstPersonController>().enabled = false;
		Destroy(this.gameObject);

	}

	public void Lose()
	{
		
		gameController.GetComponent<GameControllerO>().Sadness(5);
		playerO.GetComponent<FirstPersonController>().enabled = false;
		Destroy(this.gameObject);

	}
		
}
