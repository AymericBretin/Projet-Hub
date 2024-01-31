using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin : MonoBehaviour
{
    public int nb_coin = 0;
    public TMP_Text moneyCounter;
    void Start()
    {
        
    }

    void Update()
    {
        moneyCounter.SetText(nb_coin.ToString());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin") {
            nb_coin += 1;
            Destroy(other.gameObject);
        }
    }
}
