using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DTT_GameController : MonoBehaviour {

	public Text victoryText;
	public Text defeatText;
	// creates references for spawned object, timer and texts
	public GameObject objectSpawned;
	float timer = 3f;

	// Use this for initialization
	void Start () 
	{
		Invoke ("objectSpawn", 1);
		Invoke ("objectSpawn", 1);
		Invoke ("objectSpawn", 1);
		Invoke ("objectSpawn", 1);
		//spawn object 4 times
		victoryText.enabled = false;
		defeatText.enabled = false;
		//disables the victory and defeat text

	}
	
	// Update is called once per frame
	void Update () 
	{
		//timer counts back from 3 until it reaches 0
		timer -= Time.deltaTime;
		if(timer <= 0f)
			victoryText.enabled = true;
		// if player survives for 3 seconds then they win;
	}
	void OnTriggerEnter2D(Collider2D other)
	{ //when player is hit by DTT enemy they lose
		if (other.gameObject.tag == "DTTEnemy") 
		{
			//if the other object tag equals DTTEnemy then start the defeat function
			Defeat ();
			Destroy (other.gameObject);
			Debug.Log ("Dead");
		}
	}

	public void Defeat()
	{
		defeatText.enabled = true;
	}

	void objectSpawn()
	{
		//Spawns objects between x and y
		float X = Random.Range (-7f, 6.98f);
		float Y = 4.86f;
		float Z = -1;
		Vector3 Spawn = new Vector3 (X, Y, Z);
		Instantiate (objectSpawned, Spawn, Quaternion.identity);
		Debug.Log("SpawnedObject");
	}

}


//Kotis