using UnityEngine;
using System.Collections;

public class Randomiser : MonoBehaviour 
{
	//Material Arrays
	public Sprite[] goalMat;
	public Sprite[] playerMat; 

	public GameObject[] goalMatGO; 

	//Playter and Gaol GameObjects
	public GameObject goal;
	public GameObject player;

	//PLatform GameObjects
	public GameObject platOne;
	public GameObject platTwo;
	public GameObject platThree; 

	//spawn point variables
	public GameObject leftBorder;
	public GameObject rightBorder;
	public GameObject topBorder;

	//spawn variable for platform one
	public GameObject platOneOne;
	public GameObject platOneTwo;

	//spawn variable for platform three
	public GameObject platTwoOne;
	public GameObject platTwoTwo;

	//spawn variable for platform three
	public GameObject platThreeOne;
	public GameObject platThreeTwo;

	//DTTRandomiser Variables
	public GameObject[] dTTEnemy; 
	public int enemyCount;
	public int hazardCount;
	public float spawnWait;

	// Use this for initialization
	void Start () 
	{
		if (gameObject.tag != "PlatCamera")
		{
			RandomPlayer();
		}

		if (gameObject.tag != "DTTCamera" && gameObject.tag != "PlatCamera")
		{
			RandomGoal();
		}

		if (gameObject.tag == "DTTCamera")
		{
			StartCoroutine(RandomEnemyDTT());
		}

		if (gameObject.tag == "PlatCamera")
		{
			RandomPlat();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void RandomPlayer()
	{
		//randomize player start position
		player.transform.position = new Vector3(Mathf.Lerp(leftBorder.transform.position.x, rightBorder.transform.position.x, Random.Range(0f, 1f)), player.transform.position.y, player.transform.position.z);

		//get random material
		//Sprite randomMatP = playerMat[Random.Range(0, playerMat.Length)]; 

		// apply random material
		//player.GetComponent<SpriteRenderer>().sprite = randomMatP;
	}

	void RandomGoal()
	{
		//randomize goal start position
		goal.transform.position = new Vector3(Mathf.Lerp(leftBorder.transform.position.x, rightBorder.transform.position.x, Random.Range(0f, 1f)), goal.transform.position.y, goal.transform.position.z);

		//get random material
		//Sprite randomMatG = goalMat[Random.Range(0, goalMat.Length)]; 
		GameObject randomMatGo = goalMatGO[Random.Range(0, goalMat.Length)];

		// apply random material
		//goal.GetComponent<SpriteRenderer>().sprite = randomMatG;
		Instantiate (randomMatGo, goal.transform.position, goal.transform.rotation);
	}

	void RandomPlat()
	{
		platOne.transform.position = new Vector3(Mathf.Lerp(platOneOne.transform.position.x, platOneTwo.transform.position.x, Random.Range(0f, 1f)), Mathf.Lerp(platOneOne.transform.position.y, platOneTwo.transform.position.y, Random.Range(0f, 1f)), platOne.transform.position.z);
		platTwo.transform.position = new Vector3(Mathf.Lerp(platTwoOne.transform.position.x, platTwoTwo.transform.position.x, Random.Range(0f, 1f)), Mathf.Lerp(platTwoOne.transform.position.y, platTwoTwo.transform.position.y, Random.Range(0f, 1f)), platTwo.transform.position.z);
		platThree.transform.position = new Vector3(Mathf.Lerp(platThreeOne.transform.position.x, platThreeTwo.transform.position.x, Random.Range(0f, 1f)), Mathf.Lerp(platThreeOne.transform.position.y, platThreeTwo.transform.position.y, Random.Range(0f, 1f)), platThree.transform.position.z);

	}

	IEnumerator RandomEnemyDTT()
	{
		for (int i = 0; i < hazardCount; i++)
		{	
			//get new spawnpoints
			Vector3 dTTEnemyT = topBorder.transform.position; 
			dTTEnemyT = new Vector3(Random.Range(leftBorder.transform.position.x, rightBorder.transform.position.x),dTTEnemyT.y,dTTEnemyT.z);
		
			//spawn enemies
			Instantiate(dTTEnemy[Random.Range(0, 2)], dTTEnemyT,Quaternion.identity);
			yield return new WaitForSeconds(spawnWait);
		}
		//increase the amount of enemies spawned each time
		hazardCount += 2;
		yield return new WaitForSeconds (0.2f);
		StartCoroutine(RandomEnemyDTT());
	}

}


//Xblivior
