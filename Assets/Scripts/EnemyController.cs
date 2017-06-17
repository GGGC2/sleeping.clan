using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;
	private bool hittingWall;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	public Rigidbody2D rigi;

	private bool notAtEdge;
	public Transform edgeCheck;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		rigi.velocity = new Vector2(moveSpeed,0);
	}
}
