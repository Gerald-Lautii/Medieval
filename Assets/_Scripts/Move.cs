using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2;

    public float jump = 3;

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-speed, rb2D.velocity.y);
        }
        else 
        {
            rb2D.velocity = new Vector2 (0,rb2D.velocity.y);
        }
        if (Input.GetKey("w") && Jump.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x,jump);
        }





    }
}
