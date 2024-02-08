using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowVesselHit : MonoBehaviour
{
    public GameObject[] Vie;
    public int BossHealth = 3;
    public int BossHit = 0;
    public bool CondiAttack = true;
    public BossFight bossFight;
    public Animator End;
    public bool EndBoss = false;
    public Animator Anim;

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
    public void HitBoss()
    {
        Anim.SetBool("Hit", false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && CondiAttack == true)
        {
            CondiAttack = false;
            Debug.Log("HIT");
            BossHealth -= 1;
            Anim.SetBool("Hit", true);
            if (BossHealth == 0) {
                EndBoss = true;
                End.SetBool("Start", true);
            }
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        Anim.SetBool("Hit", false);
        CondiAttack = true;
    }
}
