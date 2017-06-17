using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
	public int initialAffection;
	public int[] affectionArray;
	public int[] bonusArray;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetAffection(int choice)
	{
		initialAffection = affectionArray[choice];
	}
}
