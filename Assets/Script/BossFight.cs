using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=UnityEngine.Random;

public class BossFight : MonoBehaviour
{
    public Animator RainSpike;
    public Animator LeftSpike;
    public Animator RightSpike;
    public Animator FloorSpike;
    public Animator ExplosionSpike;
    public Animator BossWalk;
    public Animator Drop;
    public int randomNumber;
    public int randomNumber2;
    public int SaveNb = -1;
    public int NbAttack = 0;
    public bool StartBool = false;
    public StartGame startGame;
    public bool PlayerCanBeHit = true;
    public int Phase = 0;
    public ShadowBossHit shadowBossHit;
    public ShadowVesselHit shadowVesselHit;
    // Start is called before the first frame update
    void Start()
    {
        shadowBossHit = FindObjectOfType<ShadowBossHit>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (StartBool == false && startGame.start == true) {
            Debug.Log("Start");
            NewNumber();
            StartBool = true;
        }
    }

    public void NewNumber()
    {
        Debug.Log("New Number" + Phase);
        PlayerCanBeHit = true;
        if (shadowVesselHit.EndBoss == false) {
            if (NbAttack <= 3) {
            if (Phase == 0) {
                randomNumber = Random.Range(0, 3);
            }
            if (Phase == 1) {
                randomNumber = Random.Range(0, 5);
            }
            if (randomNumber == SaveNb) {
                Debug.Log("Same");
                NewNumber();
                return;
            } else {
                SaveNb = randomNumber;
                Debug.Log("Save " + SaveNb);
                if (randomNumber == 0) {
                    RainSpike.SetBool("Start", true);
                }
                if (randomNumber == 1) {
                    ExplosionSpike.SetBool("Start", true);
                }
                if (randomNumber == 2) {
                    FloorSpike.SetBool("Start", true);
                }
                if (randomNumber == 3) {
                    RightSpike.SetBool("Start", true);
                }
                if (randomNumber == 4) {
                    LeftSpike.SetBool("Start", true);
                }
                NbAttack += 1;
                StartCoroutine(Timer());
            }
        } else {
            if (Phase == 0) {
                shadowBossHit.CondiAttack = true;
                shadowVesselHit.CondiAttack = true;
                randomNumber2 = Random.Range(0, 2);
                if (randomNumber2 == 0) {
                    BossWalk.SetBool("Start", true);
                }
                if (randomNumber2 == 1) {
                    BossWalk.SetBool("Start2", true);
                }
                NbAttack = 0;
                StartCoroutine(Timer());
            }
            if (Phase == 1) {
                shadowBossHit.CondiAttack = true;
                shadowVesselHit.CondiAttack = true;
                NbAttack = 0;
                Drop.SetBool("Start", true);
                StartCoroutine(Timer());
            }
        }
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        Drop.SetBool("Start", false);
        ExplosionSpike.SetBool("Start", false);
        FloorSpike.SetBool("Start", false);
        RightSpike.SetBool("Start", false);
        LeftSpike.SetBool("Start", false);
        RainSpike.SetBool("Start", false);
        BossWalk.SetBool("Start", false);
        BossWalk.SetBool("Start2", false);
    }
}
