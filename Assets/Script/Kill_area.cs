using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_area : MonoBehaviour
{
    public GameObject Player;
    public GameObject Check_point;
    void Start()
    {
        Check_point = Player.transform.position;
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Player.gameObject.tag == "Kill") {
            ;
        }
    }
}
