using UnityEngine;
using System.Collections;

public class DTTEnemy : MonoBehaviour {
	//sets the rigidbody and sets the enemies' drop speed
	public Rigidbody2D Enemy;
	float dropSpeed = 5f;
	// Use this for initialization
	void Start () {
		//gets the enemies' rigidbody
		Enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//causes the enemy to fall downwards
		Enemy.velocity = transform.up * -dropSpeed;

	}
}
