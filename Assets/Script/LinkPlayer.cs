using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkPlayer : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        
    }
    void Update()
    {
        Player = GameObject.Find("Player");   
        if (Player != null) {
            Vector2 player_pos = Player.transform.position;
            transform.position = new Vector2(player_pos.x, player_pos.y);
        }
    }
}
