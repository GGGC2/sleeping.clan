using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MovingObject {
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
