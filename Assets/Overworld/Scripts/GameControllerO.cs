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
		SpawnArcades();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	//NOTE: Make timer for while loop. IEnumerator? with random.range countdown timer 
	void SpawnArcades()
	{
		//variables
		Vector2 randomPos = new Vector2();
		flag = false;

		while (!flag)
		{
			//get random spot
			randomPos += Random.insideUnitCircle * 5;

			//pick a spot
			Vector3 possibleSpot = new Vector3 (randomPos.x, 1.5f, randomPos.y);

			// if spot is good (if there is nothing in the check)
			if (!Physics.CheckSphere(possibleSpot, 3f, arcadeLayer))
			{
				//set flag = true
				flag = true;
				//spawn random arcade machine
				Instantiate(arcadeMachines[Random.Range(0, arcadeMachines.Length)], possibleSpot, Quaternion.identity);
			}

		}

		Invoke("SpawnArcades",0.05f);
		
	}
}


//Xblivior
