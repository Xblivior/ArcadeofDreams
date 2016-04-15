using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DTT_GameController : MonoBehaviour {

	public Text victoryText;
	public Text defeatText;

	public GameObject objectSpawner;
	float timer = 3f;

	// Use this for initialization
	void Start () 
	{
		Invoke ("objectSpawn", 1);
		Invoke ("objectSpawn", 1);
		Invoke ("objectSpawn", 1);
		Invoke ("objectSpawn", 1);
		victoryText.enabled = false;
		defeatText.enabled = false;


	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if(timer <= 0f)
			victoryText.enabled = true;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "DTTEnemy") 
		{
			
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
		float X = Random.Range (-7f, 6.98f);
		float Y = 4.86f;
		float Z = -1;
		Vector3 Spawn = new Vector3 (X, Y, Z);
		Instantiate (objectSpawner, Spawn, Quaternion.identity);
		Debug.Log("SpawnedObject");
	}

}
