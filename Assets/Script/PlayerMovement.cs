using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jump = 10;
    public Rigidbody2D rb;
    public bool onFloor = false;
    private bool isFacingRight = true;
    private float inputX;
    public Animator anim;

    public StartGame startGame;
    void Update()
    {
        if (startGame.start == true) {
            inputX = Input.GetAxis("Horizontal");

            if (Input.GetButtonDown("Jump") && onFloor == true) {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                onFloor = false;
            } else if (Input.GetButtonDown("Jump2") && onFloor == true) {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                onFloor = false;
            }

            anim.SetFloat("Move", Mathf.Abs(inputX));
            rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground") {
            onFloor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground") {
            onFloor = false;
        }
    }


    private void Flip()
    {
        if (isFacingRight && inputX < 0f || !isFacingRight && inputX > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
