using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerMovement playerMovement;
    public GameObject Player;
    public int Grav = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetGravity()
    {
        Player.transform.rotation = Quaternion.Euler(0, 0, 0);
        Debug.Log("Basic Grav");
        Grav = 0;
        rb.gravityScale = 3;
        playerMovement.jump = 12;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerGrav")
        {
            if (Grav == 0)
            {
                playerMovement.jump = -12;
                Player.transform.rotation = Quaternion.Euler(180, 0, 0);
                Debug.Log("Reverse Grav");
                Grav = 1;
                rb.gravityScale = -3;
            }
            else if (Grav == 1)
            {
                playerMovement.jump = 12;
                Player.transform.rotation = Quaternion.Euler(0, 0, 0);
                Debug.Log("Basic Grav");
                Grav = 0;
                rb.gravityScale = 3;
            }
        }
    }
}
