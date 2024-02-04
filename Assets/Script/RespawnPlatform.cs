using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlatform : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Falling falling;
    public Falling falling2;
    public Falling falling3;
    public GameObject Platform1;
    public GameObject Platform2;
    public GameObject Platform3;
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
            if (falling != null)
            {
                falling.Fall = 0;
            }
            if (falling2 != null)
            {
                falling2.Fall = 0;
            }
            if (falling3 != null)
            {
                falling3.Fall = 0;
            }
            Platform1.transform.position = pos1.position;
            Platform2.transform.position = pos2.position;
            Platform3.transform.position = pos3.position;
        }
    }
}
