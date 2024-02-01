using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIdle : MonoBehaviour
{
    public Animator Dino1;
    public Animator Dino2;
    public Animator Dino3;
    public Animator Dino4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetIdle()
    {
        Dino1.SetBool("Idle", true);
        Dino2.SetBool("Idle", true);
        Dino3.SetBool("Idle", true);
        Dino4.SetBool("Idle", true);
    }

    void RmIdle()
    {
        Dino1.SetBool("Idle", false);
    }
}
