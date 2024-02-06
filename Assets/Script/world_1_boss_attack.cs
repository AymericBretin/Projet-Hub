using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class world_1_boss_attack : MonoBehaviour
{
    public bool hit = false;
    public HealthBar healthBar;
    public GameObject Check_point;
    public GameObject Player;
    public Rigidbody2D rb;
    public bool ontrigger = false;
    void Start()
    {
        Player = GameObject.Find("Player");
        rb = Player.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (hit == true && ontrigger == true) {
            rb.velocity = Vector3.zero;
            healthBar.Health -= 1;
            Player.transform.position = new Vector3 (Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
            StartCoroutine(Timer());
            hit = false;
            if (healthBar.Health == -1) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ontrigger = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        ontrigger = false;
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
