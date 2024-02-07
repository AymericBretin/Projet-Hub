using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathbossw2 : MonoBehaviour
{
    public Animator death;
    public Rigidbody2D rb;
    public bool pass = true;
    public world2_boss World2_boss;
    public Move_boss move_boss;
    void Start()
    {
    }

    void Update()
    {
        if (World2_boss.nb_hit == 4 && pass == true)
        {
            Debug.Log("graviti");
            pass = false;
            rb.gravityScale = 2;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("ground");
            rb.velocity = Vector3.zero;
            death.SetBool("death", true);
            rb.gravityScale = 0;
            move_boss.Condi = false;
        }
    }
}
