using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerControllerO : MonoBehaviour 
{
	public GameObject arcade;
	public GameObject ground;
	public Camera playerView;


	public Text startTex;

	// Use this for initialization
	void Start () 
	{
		startTex.enabled = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		//make sure the ground follow the player
		ground.transform.position = new Vector3 (transform.position.x, 0f, transform.position.z);

		//call CheckArcade() to see if player is looking at an arcade
		CheckArcade();

		// if there is an arcade
		if (arcade != null)
		{
			//and the player presses f
			if (Input.GetKeyDown(KeyCode.F))
			{
				//switch FPC off
				gameObject.GetComponent<FirstPersonController>().enabled = false;

				//tell the arcade to start
				arcade.GetComponent<ArcadeController>().StartGameCam();

				//switch FPCam off
				//playerView.enabled = false;

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
				//make arcade = to that arcade
				arcade = hit.transform.gameObject;

				//and show Start Text
				startTex.enabled = true;
			}

		}

		//else if it hits nothing
		else 
		{
			//make arcade empty
			arcade = null;

			//and show no text
			startTex.enabled = false;

		}

	}
}

//Xbilivior
