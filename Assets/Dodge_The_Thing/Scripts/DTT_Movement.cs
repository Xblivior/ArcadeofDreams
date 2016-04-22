using UnityEngine;
using System.Collections;

public class DTT_Movement : MonoBehaviour {
	//create references for player movement, rigidbody and speed
	 float playerMove;
	float moveSpeed = 4f;
	public Rigidbody2D Player;
	public GameObject gameController;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//player moves along the horizontal axis
		playerMove = Input.GetAxisRaw ("Horizontal");
		Vector3 movement;
		movement = new Vector3 (playerMove, 0,0);
		movement = movement * moveSpeed * Time.deltaTime;

		transform.Translate (movement); // Left and right movement


	}
	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.tag == "DTTDodge")
		{
			gameController.GetComponent<DTT_GameController> ().Defeat ();
			Destroy (other.gameObject);

		}
	
		
	}
}

// kotis