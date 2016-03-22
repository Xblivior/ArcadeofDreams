using UnityEngine;
using System.Collections;

public class ThrownController : MonoBehaviour 
{
	public float speed;

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
		if (other.tag == "Goal")
		{
			
		}
	}
}
