using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	
	private bool grounded;
	private bool doubleJumped;
	private Rigidbody2D rigi;


	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

	}

	// Update is called once per frame
	void Update () {
		
		if(grounded)
			doubleJumped = false;

		if (Input.GetKeyDown (KeyCode.Space) && grounded)
		{
			//rigi.velocity = new Vector2(rigi.velocity.x, jumpHeight);
			Jump ();
		}

		if (Input.GetKeyDown (KeyCode.Space) && !doubleJumped && !grounded)
		{
			//rigi.velocity = new Vector2(rigi.velocity.x, jumpHeight);
			Jump ();
			doubleJumped = true;
		}

		if (Input.GetKey (KeyCode.D))
		{
			rigi.velocity = new Vector2(moveSpeed, rigi.velocity.y);
		}

		if (Input.GetKey (KeyCode.A))
		{
			rigi.velocity = new Vector2(-moveSpeed, rigi.velocity.y);
		}

	}

	public void Jump()
	{
		rigi.velocity = new Vector2(rigi.velocity.x, jumpHeight);
	}
}
