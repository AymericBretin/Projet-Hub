using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTime : MonoBehaviour
{
    public TMP_Text Time1;
    public TMP_Text Time2;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Time1.SetText(gameManager.TimeMinute.ToString() + "Min");
        Time2.SetText(gameManager.TimeMinute.ToString() + "Min");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
