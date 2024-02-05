using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBossHit : MonoBehaviour
{
    public Animator HitSmoke;
    public GameObject[] Vie;
    public int BossHealth = 3;
    public int BossHit = 0;
    public bool CondiAttack = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHealth == 3) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(true);
        }
        if (BossHealth == 2) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(true);
            Vie[2].SetActive(false);
        }
        if (BossHealth == 1) {
            Vie[0].SetActive(true);
            Vie[1].SetActive(false);
            Vie[2].SetActive(false);
        }
        if (BossHealth == 0) {
            Vie[0].SetActive(false);
            Vie[1].SetActive(false);
            Vie[2].SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && CondiAttack == true)
        {
            CondiAttack = false;
            Debug.Log("HIT");
            BossHealth -= 1;
            HitSmoke.SetBool("Hit", true);
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        CondiAttack = true;
        HitSmoke.SetBool("Hit", false);
    }
}
