﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour {
	public MapManager mapManager;
	public int sceneNumber;
	// Use this for initialization
	void Start () {
		mapManager = FindObjectOfType<MapManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
			
	void OnTriggerEnter2D(Collider2D other){

	}
	
}
 
