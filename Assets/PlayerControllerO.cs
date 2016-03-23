using UnityEngine;
using System.Collections;

public class PlayerControllerO : MonoBehaviour 
{
	public GameObject arcade;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckArcade();
		if (arcade != null)
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				arcade.GetComponent<ArcadeController>().NextLevel(); 
			}
		}
	}

	void CheckArcade()
	{
		//make a raycast
		RaycastHit hit;
		// if the raycast hits something in 2 units
		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			
			//if it hits an aracde machine
			if (hit.transform.tag == "Arcade")
			{
				arcade = hit.transform.gameObject;
			}
			else
			{
				arcade = null;
			}
		}

	}
}
