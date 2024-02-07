using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storm_kill : MonoBehaviour
{
    public BoxCollider2D b1;
    public tornado_maker Tornado_Maker;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void set_colider_storm()
    {
        b1.enabled = true;
    }

    public void unset_colider_storm()
    {
        b1.enabled = false;
    }

    public void reset_kill()
    {
        Tornado_Maker.set_kill = true;
    }
}
