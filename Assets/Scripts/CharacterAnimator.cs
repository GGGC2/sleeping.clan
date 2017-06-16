using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour {
	
	public Rigidbody2D rigi;
	public Animator animator;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool grounded;

	// Use this for initialization
	void Start () {
		animator.SetBool("isRight",true);
		animator.SetBool("isMoving",false);
		animator.SetBool("isGround",true);
		animator.SetBool("isAttacking",false);
	}
	
	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space) && grounded)
		{
			animator.SetBool("isGround",false);
		}

		if(Input.GetKey (KeyCode.RightArrow))
		{
			animator.SetBool("isRight",true);
			animator.SetBool("isMoving",true);
		}
		
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			animator.SetBool("isRight",false);
			animator.SetBool("isMoving",true);
		}
		if((Input.GetKeyUp (KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.LeftArrow)) && grounded)
		{
			animator.SetBool("isMoving",false);
		}
		
		if(rigi.velocity.y == 0) animator.SetBool("isGround", true);
	}
}
