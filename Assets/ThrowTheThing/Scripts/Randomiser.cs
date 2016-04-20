using UnityEngine;
using System.Collections;

public class Randomiser : MonoBehaviour 
{
	//Material Arrays
	public Sprite[] goalMat;
	public Sprite[] playerMat; 

	//Playter and Gaol GameObjects
	public GameObject goal;
	public GameObject player;

	//spawn point variables
	public float xMinG, xMaxG, yPosG; //Gaol
	public float xMinP, xMaxP, yPosP; //Player

	public GameObject leftBorder;
	public GameObject rightBorder;

	// Use this for initialization
	void Start () 
	{
		RandomPlayer();
		RandomGoal();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void RandomPlayer()
	{
		//randomize player start position
		player.transform.position = Vector2.Lerp(leftBorder.transform.position, rightBorder.transform.position, Random.Range(0, 1));

		//get random material
		//Sprite randomMatP = playerMat[Random.Range(0, playerMat.Length)]; 

		// apply random material
		//player.GetComponent<SpriteRenderer>().sprite = randomMatP;
	}

	void RandomGoal()
	{
		//randomize player start position
		goal.transform.position = Vector2.Lerp(leftBorder.transform.position, rightBorder.transform.position, Random.Range(0, 1));

		//get random material
		//Sprite randomMatG = goalMat[Random.Range(0, goalMat.Length)]; 

		// apply random material
		//goal.GetComponent<SpriteRenderer>().sprite = randomMatG;
	}


}


//Xblivior
