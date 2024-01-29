using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkCamera : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        Vector2 player_pos = Player.transform.position;
        transform.position = new Vector3(player_pos.x, -0.7880001f, -10f);
    }
}
