using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : PlayerMovement
{
    

    public override void Update()
    {

        checkForJump();
        base.Update();
    }


    void checkForJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            base.Jump = true;
        }

    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    
}
