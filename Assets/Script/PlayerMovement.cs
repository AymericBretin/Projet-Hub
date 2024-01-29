using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jump = 10;
    public Rigidbody2D rb;
    public bool onFloor = false;
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && onFloor == true) {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            onFloor = false;
        }

        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            onFloor = true;
        }
    }

}
