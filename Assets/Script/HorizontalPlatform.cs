using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatform : MonoBehaviour
{
    public Transform pos1, pos2;
    public int Speed;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = pos2.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, pos1.position)  < .1f) targetPos = pos2.position;

        if (Vector2.Distance(transform.position, pos2.position) < .1f) targetPos = pos1.position;

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
