using UnityEngine;
using System.Collections;

public class Randomiser : MonoBehaviour 
{
	//Material Arrays
	public Material[] goalMat;
	public Material[] playerMat; 

	//Playter and Gaol GameObjects
	public GameObject goal;
	public GameObject player;

	//spawn point variables
	public float xMinG, xMaxG, yPosG; //Gaol
	public float xMinP, xMaxP, yPosP; //Player

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
		player.transform.position = new Vector3(Random.Range(xMinP, xMaxP), yPosP, 0f);

		//get random material
		Material randomMatP = playerMat[Random.Range(0, 4)]; 

		// apply random material
		player.GetComponent<Renderer>().material = randomMatP;
	}

	void RandomGoal()
	{
		//randomize player start position
		goal.transform.position = new Vector3(Random.Range(xMinG, xMaxG), yPosG, 0f);

		//get random material
		Material randomMatG = playerMat[Random.Range(0, 4)]; 

		// apply random material
		goal.GetComponent<Renderer>().material = randomMatG;
	}


}
