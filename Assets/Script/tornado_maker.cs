using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tornado_maker : MonoBehaviour
{
    public int nb = 0;
    public world2_boss World2_boss;
    public GameObject flag;
    public GameObject storm, storm2, storm3;
    public GameObject build;
    public GameObject button;
    public GameObject button2;
    public Animator reversed;
    public int champ = 0;
    public int nb_att = 0;
    public bool set_kill = true;
    public float t = 5;

    void Start()
    {
        StartCoroutine(start());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generate_number()
    {
        build.SetActive(false);
        button.SetActive(false);
        button2.SetActive(false);
        set_kill = true;
        nb = Random.Range(1, 6);
        nb_att += 1;
        if (nb_att < 4 && World2_boss.nb_hit < 4)
        {
            if (nb == 1)
            {
                reversed.SetInteger("right", 1);
            }
            if (nb == 2)
            {
                reversed.SetInteger("right", 2);
            }
            if (nb == 3)
            {
                storm.SetActive(true);
            }
            if (nb == 4)
            {
                storm2.SetActive(true);
            }
            if (nb == 5)
            {
                storm3.SetActive(true);
            }
            StartCoroutine(next_nb());
        } else if (nb_att == 4 && champ == 0) {
            champ = 1;
            t -= 1;
            nb_att = 0;
            build.SetActive(true);
            button.SetActive(true);
            StartCoroutine(myCoroutine());
        } else if (nb_att == 4 && champ == 1)
        {
            champ = 0;
            t -= 1;
            nb_att = 0;
            button2.SetActive(true);
            StartCoroutine(myCoroutine2());
        } else if (World2_boss.nb_hit == 4)
        {
            flag.SetActive(true);
        }
    }

    public void restart_tornado()
    {
        reversed.SetInteger("right", 0);
    }
    IEnumerator start()
    {
        yield return new WaitForSeconds(3);
        generate_number();
    }

    IEnumerator next_nb()
    {
        yield return new WaitForSeconds(t);
        generate_number();
    }
    IEnumerator myCoroutine()
    {
        build.SetActive(true);
        button.SetActive(true);
        yield return new WaitForSeconds(5f);
        generate_number();
    }
    IEnumerator myCoroutine2()
    {
        button2.SetActive(true);
        yield return new WaitForSeconds(5f);
        generate_number();
    }
}
