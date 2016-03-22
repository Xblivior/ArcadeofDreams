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
	public float xMinG, xMaxG, yMinG, yMaxG; //Gaol
	public float xMinP, xMaxP, yMinP, yMaxP; //Player

	public GameController gameController;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
