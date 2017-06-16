using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
	public MapManager mapManager;
	// Use this for initialization
	void Start () {
		mapManager = FindObjectOfType<MapManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
			
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			Debug.Log("Checkpoint Activated" + transform.position);
			mapManager.currentCheckpoint = gameObject;
		}
	
	}
}
 
