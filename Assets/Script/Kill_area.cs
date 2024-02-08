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
    public GameObject PlayerParticle;
    public ParticleSystem particleBurst;

    public int Time = 0;
    void Start()
    {
        Player = GameObject.Find("Player");
        rb = Player.GetComponent<Rigidbody2D>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        changeGravity = FindObjectOfType<ChangeGravity>();
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
        if (changeGravity != null)
        {
            if (other.gameObject.tag == "Player" && changeGravity.Grav == 1)
            {
                changeGravity.ResetGravity();
            }
        }
        if (other.gameObject.tag == "Player" && Time == 0)
        {
            Player.SetActive(false);
            playerMovement.onFloor = true;
            rb.velocity = Vector3.zero;
            Time = 1;
            healthBar.Health -= 1;
            if (particleBurst != null) {
                particleBurst.Emit(1);
            }
            StartCoroutine(Timer());
        }
        if (healthBar.Health == -1) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.8f);
        Player.transform.position = new Vector3 (Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
        Time = 0;
        Player.SetActive(true);
    }
}
