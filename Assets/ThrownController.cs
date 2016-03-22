using UnityEngine;
using System.Collections;

public class ThrownController : MonoBehaviour 
{
	public float speed = 5f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(transform.up * speed * Time.deltaTime);
	}


}
