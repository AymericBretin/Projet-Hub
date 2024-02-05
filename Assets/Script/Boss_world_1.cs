using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_world_1 : MonoBehaviour
{
    public Animator Boss;
    private int nb_hit;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            Vector3	v = rb.velocity;
            v.y = 15;
            rb.velocity = v;
            if (nb_hit < 4) {
                Boss.SetBool("hit", true);
            } else {
                Boss.SetBool("death", true);
            }
            StartCoroutine(Timer());
            nb_hit += 1;
            print("la");
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        Boss.SetBool("hit", false);
        Boss.SetBool("death", false);
    }
}
