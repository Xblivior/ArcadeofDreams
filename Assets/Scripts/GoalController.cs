using UnityEngine;
using System.Collections;

public class GoalController : MonoBehaviour 
{
	public GameObject gameController;

	void OnTriggerEnter (Collider other)
	{
		//if the thrown thing hits the goal
		if (other.gameObject.tag == "Thrown")
		{
			// tell the gamecontroller its a win
			gameController.GetComponent<GameController>().Victory();
			Destroy(other.gameObject);

		}
	}


}
