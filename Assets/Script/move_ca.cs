using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_ca : MonoBehaviour
{
    public GameObject Player;
    private float speed = 0.1f;
    public StartGame startGame;
    public HealthBar healtBar;
    private int cont = 0;
    private int health_point = 0;
    void Start()
    {
        Vector2 player_pos = Player.transform.position;
        speed = player_pos.x;
        health_point = healtBar.Health;
    }

    void FixedUpdate()
    {
        if (startGame.start == true) {
            speed += 0.1f;
            transform.position = new Vector3(speed, -0.7880001f, -10f);
        }
        if (health_point != healtBar.Health) {
            Vector2 player_pos = Player.transform.position;
            speed = player_pos.x;
            health_point = healtBar.Health;
        }

    }
}
