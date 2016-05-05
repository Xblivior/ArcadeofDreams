using UnityEngine;
using System.Collections;

public class wallCollider : MonoBehaviour
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
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "CTTProjectile") 
		{
			gameController.GetComponent<GameController>().FailGame();
			Destroy (other.gameObject);
		}
	}
}

//Eugene