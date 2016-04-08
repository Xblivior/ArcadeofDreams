using UnityEngine;
using System.Collections;

public class DTT_Movement : MonoBehaviour {
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
		
		playerMove = Input.GetAxisRaw ("Horizontal");
		Vector3 movement;
		movement = new Vector3 (playerMove, 0,0);
		movement = movement * moveSpeed * Time.deltaTime;

		transform.Translate (movement);

		if (transform.position.x <= -8.003f)
			transform.position = new Vector3 (7.8f, transform.position.y, transform.position.z);
		else if (transform.position.x >= 7.99f)
			transform.position = new Vector3 (-8f, transform.position.y, transform.position.z);

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