using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : PlayerMovement
{
    

    public override void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            base.Jump = true;
        }

        base.Update();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    
}
