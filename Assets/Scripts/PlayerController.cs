using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public GameObject thrown;
	public Transform throwSpawn;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space))
		{
			Instantiate(thrown, thrown.transform.position, thrown.transform.rotation);
		}
	}
}
