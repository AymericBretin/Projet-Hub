using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWorld : MonoBehaviour
{
    public GameObject WorldIdle;
    public GameObject NextWorld;
    public GameManager gameManager;
    public GameObject Player;
    public Transform Spawn;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.transform.position = Spawn.position;
            WorldIdle.SetActive(false);
            NextWorld.SetActive(true);
            if (gameManager.world == 2) {
                gameManager.world = 3;
            }
            if (gameManager.world == 1) {
                gameManager.world = 2;
            }
        }
    }
}
