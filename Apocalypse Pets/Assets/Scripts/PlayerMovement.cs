using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Thanks to Brackeys for this code
public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float moveSpeed = 40f;
    public float runMultiplier = 3f;

    float horizontalMove = 0f;

    public bool Jump { get; set; } = false;
    public bool Crouch { get; set; } = false;


    // Update is called once per frame
    public virtual void Update()
    {

        move();
        checkForCrouch();

    }

    void move()
    {

        horizontalMove = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? Input.GetAxisRaw("Horizontal") * moveSpeed * runMultiplier : Input.GetAxisRaw("Horizontal") * moveSpeed;

    }
    void checkForCrouch()
    {

        if (Input.GetButtonDown("Crouch"))
        {
            Crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            Crouch = false;
        }

    }

    public virtual void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, Crouch, Jump);
        Jump = false;

    }
}