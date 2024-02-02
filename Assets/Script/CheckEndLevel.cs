using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckEndLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public GameObject anim;

    public Animator animation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = FindObjectOfType<GameManager>();
        anim = GameObject.Find("Start Level");
        animation = anim.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Complete Level 1 World 1")
        {
            gameManager.Level_End = 2;
            animation.SetBool("End", true);
            Debug.Log("Find");
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 2 World 1")
        {
            gameManager.Level_End = 3;
            animation.SetBool("End", true);
            Debug.Log("Find");
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 3 World 1")
        {
            gameManager.Level_End = 4;
            animation.SetBool("End", true);
            Debug.Log("Find");
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 4 World 1")
        {
            gameManager.Level_End = 5;
            animation.SetBool("End", true);
            Debug.Log("Find");
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 5 World 1")
        {
            gameManager.Level_End = 6;
            animation.SetBool("End", true);
            Debug.Log("Find");
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 6 World 1")
        {
            gameManager.Level_End = 7;
            animation.SetBool("End", true);
            Debug.Log("Find");
            StartCoroutine(BackMap());
        }
    }

    IEnumerator BackMap ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scenes/Map/Carte", LoadSceneMode.Single);
    }
}
