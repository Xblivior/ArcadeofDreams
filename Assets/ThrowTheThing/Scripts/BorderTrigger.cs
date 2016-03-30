using UnityEngine;
using System.Collections;

public class BorderTrigger : MonoBehaviour 
{
	public GameObject gameController;

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Thrown")
		{
			// tell the gamecontroller its a win
			gameController.GetComponent<GameController>().FailGame();
			Destroy(other.gameObject);
		}
	}
}

//Xblivior
