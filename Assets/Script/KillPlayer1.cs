using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer1 : MonoBehaviour
{
    public HealthBar healthBar;
    public GameObject Player;
    public GameObject PlayerParticle;
    public ParticleSystem particleBurst;

    public int Time = 0;
    void Start()
    {
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
        if (other.gameObject.tag == "Player" && Time == 0)
        {
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
        Time = 0;
    }
}
