using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_world_1 : MonoBehaviour
{
    public Animator Boss;
    private int nb_hit = 0;
    public Rigidbody2D rb;
    public GameObject[] Vie;
    public GameObject deathzone;
    public GameObject flag;
    public BoxCollider2D BC;
    public BoxCollider2D weak;
    void Start()
    {
        StartCoroutine(start());
    }

    void Update()
    {
        if (nb_hit == 5) {
            Vie[0].SetActive(false);
            Vie[1].SetActive(false);
            Vie[2].SetActive(false);
            Vie[3].SetActive(false);
            Vie[4].SetActive(false);
        }
        if (nb_hit == 4) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(false);
            Vie[2].SetActive(false);
            Vie[3].SetActive(false);
            Vie[4].SetActive(false);
        }
        if (nb_hit == 3) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(false);
            Vie[3].SetActive(false);
            Vie[4].SetActive(false);
        }
        if (nb_hit == 2) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(true);
            Vie[3].SetActive(false);
            Vie[4].SetActive(false);
        }
        if (nb_hit == 1) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(true);
            Vie[3].SetActive(true);
            Vie[4].SetActive(false);
        }
        if (nb_hit == 0) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(true);
            Vie[3].SetActive(true);
            Vie[4].SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            Vector3	v = rb.velocity;
            v.y = 15;
            rb.velocity = v;
            if (nb_hit < 4) {
                Boss.SetBool("hit", true);
                Boss.SetInteger("after_hit", Random.Range(0, 2));
            } else {
                Boss.SetBool("death", true);
                flag.SetActive(true);
                Destroy_death();
            }
            StartCoroutine(Timer());
            nb_hit += 1;
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        Boss.SetBool("hit", false);
        Boss.SetBool("death", false);
    }
    IEnumerator start()
    {
        yield return new WaitForSeconds(2);
        Boss.SetBool("start", true);
    }
    public void Destroy_death()
    {
       Destroy(deathzone);
       Destroy(BC);
       Destroy(weak);
    }
}
