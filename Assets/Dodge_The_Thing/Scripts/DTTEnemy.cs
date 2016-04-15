using UnityEngine;
using System.Collections;

public class DTTEnemy : MonoBehaviour {

	public Rigidbody2D Enemy;
	float dropSpeed = 5f;
	// Use this for initialization
	void Start () {
		Enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Enemy.velocity = transform.up * -dropSpeed;

	}
}
