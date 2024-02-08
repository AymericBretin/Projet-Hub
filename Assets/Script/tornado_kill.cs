using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tornado_kill : MonoBehaviour
{
    public GameObject Check_point;
    public HealthBar healthBar;
    public GameObject Player;
    public Rigidbody2D rb;
    public ChangeGravity changeGravity;
    public PlayerMovement playerMovement;
    public tornado_maker Tornado_Maker;
    public int Time = 0;
    public GameObject PlayerParticle;
    public ParticleSystem particleBurst;
    void Start()
    {
        Player = GameObject.Find("Player");
        rb = Player.GetComponent<Rigidbody2D>();
        changeGravity = FindObjectOfType<ChangeGravity>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        healthBar = FindObjectOfType<HealthBar>();
        PlayerParticle = GameObject.Find("Particle Player");
        if (PlayerParticle != null) {
                particleBurst = PlayerParticle.GetComponent<ParticleSystem>();
            }
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Tornado_Maker.set_kill == true && other.gameObject.tag == "Player" && Time == 0)
        {
            Time = 1;
            if (particleBurst != null) {
                particleBurst.Emit(1);
            }
            Tornado_Maker.set_kill = false;
            Debug.Log("kill");
            playerMovement.onFloor = true;
            rb.velocity = Vector3.zero;
            healthBar.Health -= 1;
            StartCoroutine(Timer());
            if (healthBar.Health == -1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void reset_kill()
    {
        Tornado_Maker.set_kill = true;
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        Time = 0;
    }
}
