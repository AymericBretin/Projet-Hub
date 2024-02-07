using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSpike : MonoBehaviour
{
    // Start is called before the first frame update
    public HealthBar healthBar;
    public BossFight bossFight;
    public ShadowBossHit shadowBossHit;
    void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
        bossFight = FindObjectOfType<BossFight>();
        shadowBossHit = FindObjectOfType<ShadowBossHit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && bossFight.PlayerCanBeHit == true)
        {
            bossFight.PlayerCanBeHit = false;
            healthBar.Health -= 1;
            Debug.Log("Hit");
            shadowBossHit.CondiAttack = false;
        }
    }
}
