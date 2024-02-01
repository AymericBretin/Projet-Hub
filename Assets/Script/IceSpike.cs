using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpike : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 10;
    public int Drop = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Drop == 1) {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Drop = 1;
        }
    }
}
