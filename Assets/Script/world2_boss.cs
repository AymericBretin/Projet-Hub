using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class world2_boss : MonoBehaviour
{
    public GameObject[] Vie;
    public bool hit = true;
    public int nb_hit = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (nb_hit == 4)
        {
            Vie[0].SetActive(false);
            Vie[1].SetActive(false);
            Vie[2].SetActive(false);
            Vie[3].SetActive(false);
        }
        if (nb_hit == 3)
        {
            Vie[0].SetActive(true);
            Vie[1].SetActive(false);
            Vie[2].SetActive(false);
            Vie[3].SetActive(false);
        }
        if (nb_hit == 2)
        {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(false);
            Vie[3].SetActive(false);
        }
        if (nb_hit == 1)
        {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(true);
            Vie[3].SetActive(false);
        }
        if (nb_hit == 0)
        {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(true);
            Vie[3].SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && hit == true)
        {
            hit = false;
            if (nb_hit > 2)
            {
                print("dead");
            }
            nb_hit += 1;
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        hit = true;
    }
}
