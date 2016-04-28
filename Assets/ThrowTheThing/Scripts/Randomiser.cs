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
	public GameObject leftBorder;
	public GameObject rightBorder;
	public GameObject topBorder;
	//DTTRandomiser Variables
	public GameObject[] dTTEnemy; 
	public int enemyCount;
	public int hazardCount;
	public float spawnWait;

	// Use this for initialization
	void Start () 
	{
		RandomPlayer();
		if (gameObject.tag != "DTTCamera")
		{
			RandomGoal();
		}

		if (gameObject.tag == "DTTCamera")
		{
			StartCoroutine(RandomEnemyDTT());
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

		// apply random material
		//goal.GetComponent<SpriteRenderer>().sprite = randomMatG;
	}

	IEnumerator RandomEnemyDTT()
	{
		for (int i = 0; i < hazardCount; i++)
		{	//get new spawnpoints
		
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
