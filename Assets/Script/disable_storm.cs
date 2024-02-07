using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable_storm : MonoBehaviour
{
    public GameObject storm, storm2, storm3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart_storm()
    {
        storm.SetActive(false);
        storm2.SetActive(false);
        storm3.SetActive(false);
    }
}
