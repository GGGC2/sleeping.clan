using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour {

	public BoxCollider2D boxCollider;
	private Rigidbody2D rigi;

	// Use this for initialization
	void Start () {
		boxCollider = GetComponent<BoxCollider2D>();
		rigi = GetComponent<Rigidbody2D>();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
