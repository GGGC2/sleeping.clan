using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour {
	public DialogueManager dMan;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			Debug.Log("We met a new animal!");
		}
	}
}
