using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {
	public string dialogue;
	private DialogueManager dMan;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("We met a new animal!");
		dMan.ShowBox(dialogue);
	}
}
