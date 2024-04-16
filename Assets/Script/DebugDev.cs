using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDev : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.B) && Input.GetKeyDown(KeyCode.N)) {
            gameManager.Level_End = 19;
        }
    }
}
