using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DTT_GameController : MonoBehaviour {

	public Text victoryText;
	public Text defeatText;

	public GameObject objectSpawner;

	// Use this for initialization
	void Start () 
	{
		victoryText.enabled = false;
		defeatText.enabled = false;
		Invoke ("objectSpawn", 1);

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Defeat()
	{
		defeatText.enabled = true;
	}

	void objectSpawn()
	{
		float X = Random.Range (-7f, 6.98f);
		float Y = 4.86f;
		Vector2 Spawn = new Vector3 (X, Y, -1);
		Instantiate (objectSpawner, Spawn, Quaternion.identity);
		Debug.Log("SpawnedObject");
	}

}
