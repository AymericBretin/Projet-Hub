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
    public int randomNumber;
    public int SaveNb = -1;
    // Start is called before the first frame update
    void Start()
    {
        NewNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewNumber()
    {
        randomNumber = Random.Range(0, 6);
        if (randomNumber == SaveNb) {
            NewNumber();
        } else {
            SaveNb = randomNumber;
            if (randomNumber == 0) {
                RainSpike.SetBool("Start", true);
            }
            if (randomNumber == 1) {
                LeftSpike.SetBool("Start", true);
            }
            if (randomNumber == 2) {
                RightSpike.SetBool("Start", true);
            }
            if (randomNumber == 3) {
                FloorSpike.SetBool("Start", true);
            }
            if (randomNumber == 4) {
                ExplosionSpike.SetBool("Start", true);
            }
            if (randomNumber == 5) {
                BossWalk.SetBool("Start", true);
            }
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        ExplosionSpike.SetBool("Start", false);
        FloorSpike.SetBool("Start", false);
        RightSpike.SetBool("Start", false);
        LeftSpike.SetBool("Start", false);
        RainSpike.SetBool("Start", false);
        BossWalk.SetBool("Start", false);
    }
}
