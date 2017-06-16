using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
	public bool dialogueActive;

	// Use this for initialization
	void Start () {
		dBox.SetActive(false);
		dialogueActive = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Return))
		{
			dialogueActive = false;
			dBox.SetActive(false);
		}
		
	}
	public void ShowBox(string dialogue)
	{
		dialogueActive = true;
		dBox.SetActive(true);
		dText.text = dialogue;
	}
}
