using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour 
{
	public GameObject gameController;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Thrown")
		{
			gameController.GetComponent<GameController>().Victory();
		}
	}
}
