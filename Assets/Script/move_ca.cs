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
    public bool cam = true;
    private float posy_cam;
    void Start()
    {
        Vector2 player_pos = Player.transform.position;
        speed = player_pos.x;
        health_point = healtBar.Health;
        posy_cam = transform.position.y;
        posy_cam += 1;
    }

    void FixedUpdate()
    {
        if (startGame.start == true && cam == true) {
            speed += 0.1f;
            transform.position = new Vector3(speed, posy_cam, -10f);
        }
        if (health_point != healtBar.Health) {
            Vector2 player_pos = Player.transform.position;
            speed = player_pos.x;
            health_point = healtBar.Health;
        }
    }
}
