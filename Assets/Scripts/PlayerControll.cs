using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour {

public float moveSpeed;
public float jumpHeight;
private bool grounded;
public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		
	}
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(
			groundCheck.position , groundCheckRadius, whatIsGround);

	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){ // Press D 
			GetComponent<Rigidbody2D>().velocity = new Vector2(
				moveSpeed,GetComponent<Rigidbody2D>().velocity.y);


		}
		if(Input.GetKeyDown(KeyCode.Space) && grounded){ //Press Space Once
				jump();
           }
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(
				-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}
	}
	void jump(){
	
GetComponent<Rigidbody2D>().velocity = new Vector2(
					GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
	  }
	

