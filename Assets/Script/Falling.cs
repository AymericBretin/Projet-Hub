using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public int Fall = 0;
    public Transform pos2;
    public float Speed;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = pos2.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Fall > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Fall = 1;
        }
    }
}
