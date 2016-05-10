using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class ArcadeController : MonoBehaviour 
{
	public GameController gameController;
	public GameObject gameControllerO;
	public GameObject playerO;
	public Camera arcadeCam;
	public Camera playerCam;

	float timer = 3f;

	// Use this for initialization
	void Start () 
	{
		gameController = arcadeCam.GetComponent<GameController>();
		gameControllerO = GameObject.FindGameObjectWithTag ("GameController");
		playerO = GameObject.FindGameObjectWithTag("Player");
		playerCam = Camera.main;
		transform.RotateAround (transform.position, Vector3.up, Random.Range(0f, 360f));
		arcadeCam.transform.rotation = Quaternion.identity;
	}

	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;

		if (timer <= 0f)
		{
			//decrease happiness
			gameControllerO.GetComponent<GameControllerO>().Sadness(0.1f);
			timer = 1f;
		}
	}
		
	public void StartGameCam()
	{
		//tell the MiniGame Camera to start the game
		arcadeCam.gameObject.SetActive(true);
		gameController.ActivateGame();


	}

	public void Win()
	{
		//increase Happiness
		gameControllerO.GetComponent<GameControllerO>().Happiness(5f);

		//increase score
		gameControllerO.GetComponent<GameControllerO>().Score(10);

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
		gameControllerO.GetComponent<GameControllerO>().Sadness(5f);

		//enable FPC
		playerO.GetComponent<FirstPersonController>().enabled = true;

		//enable FPCam
		playerCam.enabled = true;

		//destroy arcade machine
		Destroy(this.gameObject);

	}
		
}
