using UnityEngine;
using System.Collections;

public class GameControllerO : MonoBehaviour 
{
	public GameObject[] arcadeMachines;
	public LayerMask arcadeLayer;
	bool flag = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void SpawnArcades()
	{
		Vector2 randomPos;
		flag = false;

//		while (!flag)
//		{
//
//			randomPos += Random.insideUnitCircle * 10;
//
//			//pick a spot
//			Vector3 possibleSpot = new Vector3 (randomPos.x, 1.5f, randomPos.y);
//
//			// if spot is good
//			if (!Physics.CheckSphere(possibleSpot, 3f, arcadeLayer))
//			{
//				//set flag = true
//				flag = true;
//				//spawn
//				Instantiate(arcadeMachines[Random.Range(0, arcadeMachines.Length)]);
//			}
//
//		}
		
	}
}
