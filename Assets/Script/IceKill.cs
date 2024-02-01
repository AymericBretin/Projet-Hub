using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceKill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Ice;
    public Animator Death;

    public IceSpike iceSpike;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Player");
            StartCoroutine(Timer());
        } else if (collision.gameObject.tag == "Ground")
        {
            print("Ground");
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        iceSpike.Drop = 0;
        Death.SetBool("Hit", true);
        yield return new WaitForSeconds(0.6f);
        Destroy(Ice);
    }
}
