using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMovingPllatform : MonoBehaviour
{
    public Transform pos1;
    public GameObject Platform1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Platform1.transform.position = pos1.position;
        }
    }
}
