﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {
public GameObject currentCheckpoint;

private Move player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Move>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RespawnPlayer(){
		Debug.Log("Player Respawned");
		player.transform.position = currentCheckpoint.transform.position;
		player.GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);
	}
}
