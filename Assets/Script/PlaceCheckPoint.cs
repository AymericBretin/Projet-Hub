using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCheckPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Spawn;
    public GameObject Player;
    public GameManager gameManager;
    public PlayerMovement playerMovement;
    void Start()
    {
        Player = GameObject.Find("Player");
        gameManager = FindObjectOfType<GameManager>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.P) && gameManager.Training == true && playerMovement.onFloor == true)
        {
            gameObject.transform.position = Player.transform.position;
            Spawn.transform.position = Player.transform.position;
            Debug.Log("P");
        }
    }
}
