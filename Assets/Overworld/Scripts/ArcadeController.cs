using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class ArcadeController : MonoBehaviour 
{
	public string[] nextLevel;
	public GameController gameController;
	public GameObject gameControllerO;
	public GameObject playerO;
	public Camera arcadeCam;
	public Camera playerCam;


	// Use this for initialization
	void Start () 
	{
		gameController = arcadeCam.GetComponent<GameController>();
		gameControllerO = GameObject.FindGameObjectWithTag ("GameController");
		playerO = GameObject.FindGameObjectWithTag("Player");
		playerCam = Camera.main;
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
		//tell the MiniGame Camera to start the game
		arcadeCam.gameObject.SetActive(true);
		gameController.ActivateGame();
	}

	public void Win()
	{
		//increase Happiness
		gameControllerO.GetComponent<GameControllerO>().Happiness(5);

		//enable FPC
		playerO.GetComponent<FirstPersonController>().enabled = true;

		//enable FPCam
		playerCam.enabled = true;

		//destroy arcade machine
		Destroy(this.gameObject);

	}

	public void Lose()
	{
		//decrease happiness
		gameControllerO.GetComponent<GameControllerO>().Sadness(5);

		//enable FPC
		playerO.GetComponent<FirstPersonController>().enabled = true;

		//enable FPCam
		playerCam.enabled = true;

		//destroy arcade machine
		Destroy(this.gameObject);

	}
		
}
