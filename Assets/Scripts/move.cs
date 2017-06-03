using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpHeight;
	public Rigidbody2D rigi;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool grounded;

	// Use this for initialization
	void Start () {

	}
	
	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space) && grounded)
		{
			rigi.velocity = new Vector2(rigi.velocity.x, jumpHeight);
		}

		if(Input.GetKeyDown (KeyCode.D))
		{
			rigi.velocity = new Vector2(moveSpeed, rigi.velocity.y);
		}
		
		if(Input.GetKeyDown (KeyCode.A))
		{
			rigi.velocity = new Vector2(-moveSpeed, rigi.velocity.y);

		}
	}
}
