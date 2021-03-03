using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Based on Brackeys's code
public class BirdMovement : MonoBehaviour
{

	public FlyingCharController2D controller;
	public float moveSpeed = 40f;
	public float fastMultiplier = 3f;

	float horizontalMove = 0f;

	public bool Jump { get; set; } = false;

	// Update is called once per frame
	public virtual void Update()
	{

		move();
		checkForJump();

	}

	public virtual void FixedUpdate()
	{
		// Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, Jump);
        Jump = false;

	}
	void move()
	{

		horizontalMove = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? Input.GetAxisRaw("Horizontal") * moveSpeed * fastMultiplier : Input.GetAxisRaw("Horizontal") * moveSpeed;

	}

	    void checkForJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump = true;
			UnityEngine.Debug.Log("JUMPING");
        }

    }




}