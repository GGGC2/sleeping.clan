using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlayPlayer : MonoBehaviour {
public MapManager mapManager;

	// Use this for initialization
	void Start () {
		mapManager = FindObjectOfType<MapManager>();
	}
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Boy"){

		 mapManager.RespawnPlayer();
		}
	}
}

	
		
