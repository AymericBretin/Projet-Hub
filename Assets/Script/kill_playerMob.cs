using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_playerMob : MonoBehaviour
{
    public GameObject Check_point;
    private BoxCollider2D box;
    public Animator touch;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            touch.SetBool("touch", true);
            GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(myCoroutine(other));
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    IEnumerator myCoroutine(Collider2D other)
    {
        yield return new WaitForSeconds(0.5f);
        other.transform.position = new Vector3(Check_point.transform.position.x, Check_point.transform.position.y, Check_point.transform.position.z);
        touch.SetBool("touch", false);
        yield return new WaitForSeconds(0.1f);
    }
}
