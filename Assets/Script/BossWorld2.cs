using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWorld2 : MonoBehaviour
{
    public GameObject build;
    public GameObject button;
    public GameObject button2;
    void Start()
    {
        Display_asset();
    }

    void Update()
    {
        
    }

    void Display_asset()
    {
        build.SetActive(false);
        button.SetActive(false);
        button2.SetActive(false);
        StartCoroutine(myCoroutine());
    }
    IEnumerator myCoroutine()
    {
        yield return new WaitForSeconds(15f);
        build.SetActive(true);
        button.SetActive(true);
        yield return new WaitForSeconds(10f);
        build.SetActive(false);
        button.SetActive(false);
        yield return new WaitForSeconds(10f);
        button2 .SetActive(true);
        yield return new WaitForSeconds(10f);
        Display_asset();
    }
}
