using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossStartCheckpoint : MonoBehaviour {
	public MapManager mapManager;
    public DialogueManager dMan;
	public int sceneNumber;
	// Use this for initialization
	void Start () {
		mapManager = FindObjectOfType<MapManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
			
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			dMan.ShowBox("D키를 눌러 공격하십시오.","Enter를 눌러 계속");
		}
	
	}
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            dMan.CloseBox();
        }
    }
}
 
