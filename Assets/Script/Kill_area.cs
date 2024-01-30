using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_area : MonoBehaviour
{
    public GameObject Check_point;
    void Start()
    {
        
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            other.transform.position = new Vector3 (Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
        }
    }
}
