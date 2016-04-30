using UnityEngine;
using System.Collections;

public class playerCollider : MonoBehaviour 
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
	void OnTriggerEnter(Collider other)
	{
		//Loads the victory method from the gamecontroller script once collision happens with the projectile
		if (other.gameObject.tag == "CTTProjectile") 
		{
			gameController.GetComponent<CTTGameController>().Victory();
			Destroy (other.gameObject);
		}
	}
}

//Eugene