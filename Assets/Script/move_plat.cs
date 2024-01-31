using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_plat : MonoBehaviour
{
    public float speed = 10;
    public float speed2 = -10;
    public int pass = 0;
    public Rigidbody2D rb;
    public GameObject max;
    public GameObject min;
    public GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player Folder");
    }
    void Update()
    {
        if (pass == 0) {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (max.transform.position.y < rb.transform.position.y) {
            pass = 1;
        }
        if (pass == 1) {
            rb.velocity = new Vector2(rb.velocity.x, speed2);
        }
        if (min.transform.position.y > rb.transform.position.y) {
            pass = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SetParent(other.transform);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        other.transform.SetParent(null);
    }
}
