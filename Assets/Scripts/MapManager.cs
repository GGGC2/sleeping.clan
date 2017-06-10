using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {
public GameObject currentCheckpoint;

private PlayerControll player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControll>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RespawnPlayer(){
		Debug.Log("Player Respawned");
		player.transform.position = currentCheckpoint.transform.position;
	}
}
