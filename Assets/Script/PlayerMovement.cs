using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jump = 10;
    public Rigidbody2D rb;
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }

        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }
}
