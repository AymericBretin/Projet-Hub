using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Replace_cam_world_1 : MonoBehaviour
{
    public GameObject cam;
    public Transform checkpoint;
     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("la");
            cam.transform.position = checkpoint.position;
        }
    }
}
