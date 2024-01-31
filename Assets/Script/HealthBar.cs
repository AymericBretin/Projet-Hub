using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int Health = 2;
    public GameObject FullHearth1;
    public GameObject FullHearth2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called onc
    void Update()
    {
        if (Health == 2) {
            FullHearth1.SetActive(true);
            FullHearth2.SetActive(true);
        }
        if (Health == 1) {
            FullHearth1.SetActive(false);
            FullHearth2.SetActive(true);
        }
        if (Health == 0) {
            FullHearth1.SetActive(false);
            FullHearth2.SetActive(false);
        }
    }
}
