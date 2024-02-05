using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_area : MonoBehaviour
{
    public GameObject Check_point;
    public HealthBar healthBar;
    public GameObject Player;
    public Rigidbody2D rb;
    public ChangeGravity changeGravity;
    public PlayerMovement playerMovement;

    public int Time = 0;
    void Start()
    {
        Player = GameObject.Find("Player");
        rb = Player.GetComponent<Rigidbody2D>();
        changeGravity = FindObjectOfType<ChangeGravity>();
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (changeGravity != null)
        {
            if (other.gameObject.tag == "Player" && changeGravity.Grav == 1)
            {
                changeGravity.ResetGravity();
            }
        }
        if (other.gameObject.tag == "Player" && Time == 0)
        {
            playerMovement.onFloor = true;
            rb.velocity = Vector3.zero;
            Time = 1;
            healthBar.Health -= 1;
            other.transform.position = new Vector3 (Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
            StartCoroutine(Timer());
        }
        if (healthBar.Health == -1) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        Time = 0;
    }
}
