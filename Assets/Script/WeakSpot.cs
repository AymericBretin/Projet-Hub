using System.Collections;
using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public Animator Death;
    public GameObject objectparent;
    public GameObject parent;
    public GameObject deathzone;
    public int count = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            count = 1;
            Death.SetBool("Death", true);
            Destroy(GetComponent<BoxCollider2D>());
            Destroy(parent.GetComponent<BoxCollider2D>());
            Destroy_death();
            StartCoroutine(myCoroutine());
        }
    }

    public void Destroy_death()
    {
       Destroy(deathzone);
    }
    
    IEnumerator myCoroutine ()
    {
        yield return new WaitForSeconds(1);
        Destroy(objectparent);
    }
}
