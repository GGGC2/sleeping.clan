using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
	public Text dInstruction;
	public bool dialogueActive;

	// Use this for initialization
	void Start () {
		dBox.SetActive(false);
		dialogueActive = false;
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void ShowBox(string dialogue, string instruction)
	{
		dialogueActive = true;
		dBox.SetActive(true);
		dText.text = dialogue;
		dInstruction.text = instruction;
	}
	public void CloseBox()
	{
		dialogueActive = false;
		dBox.SetActive(false);
	}
}
