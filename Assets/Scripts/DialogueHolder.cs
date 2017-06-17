using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {
	public List<string> dialogue;
	public List<string> instruction;
	public List<KeyCode> keys = new List<KeyCode>()
	{
		KeyCode.Return,
		KeyCode.Y,
		KeyCode.N
	};
	public int dialogueNumber;
	public int instructionNumber;
	public int maxDialogueNumber;
	private DialogueManager dMan;
	private bool hasEntered;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogueManager>();
		dialogueNumber = 0;
		instructionNumber = 0;
		hasEntered = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(dialogueNumber > 3 && dialogueNumber < 8)
		{
			if(Input.GetKeyDown(keys[1]))
			{
				dialogueNumber += 4;
				dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber]);
				dialogueNumber = 11;
			}
			else if(Input.GetKeyDown(keys[2]))
			{
				dialogueNumber++;
				if(dialogueNumber == 8) dialogueNumber = 11;
				dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber+1]);
			}
			
		}
		/*if(dialogueNumber == 7)
		{
			dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber+1]);
			if(Input.GetKeyDown(keys[1]))
			{
				dialogueNumber = 3;
				dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber]);
			}
			if(Input.GetKeyDown(keys[2]))
			{
				dialogueNumber = 11;
				dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber]);
			}
		}*/
		if(Input.GetKeyDown(keys[0]))
		{
			if(dialogueNumber < maxDialogueNumber-1)
			{
				dialogueNumber++;
				if(dialogueNumber > 3 && dialogueNumber < 7) instructionNumber++;
				dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber]);
				instructionNumber = 0;
			}
			else dMan.CloseBox();
			
		}
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(!hasEntered)
		{
			dMan.ShowBox(dialogue[dialogueNumber], instruction[instructionNumber]);
			hasEntered = true;
		}
	}
}
