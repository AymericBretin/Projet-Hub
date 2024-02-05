using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_cam : MonoBehaviour
{
    public GameObject cam;
    public move_ca Move_Ca;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Complete Level 5 World 1") {
            Move_Ca.cam = false;
        }
    }
}
