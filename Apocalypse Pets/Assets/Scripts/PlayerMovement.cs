﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Thanks to Brackeys for this code
public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
      

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

            UnityEngine.Debug.Log("JUMP");
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public void onLanding()
    {
        UnityEngine.Debug.Log("LANDED");
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}