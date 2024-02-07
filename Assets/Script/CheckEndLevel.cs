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
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 2 World 1")
        {
            gameManager.Level_End = 3;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 3 World 1")
        {
            gameManager.Level_End = 4;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 4 World 1")
        {
            gameManager.Level_End = 5;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 5 World 1")
        {
            gameManager.Level_End = 6;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 6 World 1")
        {
            gameManager.Level_End = 7;
            animation.SetBool("End", true);
            StartCoroutine(SaveFriend1());
        } else if (other.name == "Complete Level 1 World 2")
        {
            gameManager.Level_End = 8;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 2 World 2")
        {
            gameManager.Level_End = 9;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 3 World 2")
        {
            gameManager.Level_End = 10;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 4 World 2")
        {
            gameManager.Level_End = 11;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 5 World 2")
        {
            gameManager.Level_End = 12;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 6 World 2")
        {
            gameManager.Level_End = 13;
            animation.SetBool("End", true);
            StartCoroutine(SaveFriend2());
        } else if (other.name == "Complete Level 1 World 3")
        {
            gameManager.Level_End = 14;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 2 World 3")
        {
            gameManager.Level_End = 15;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 3 World 3")
        {
            gameManager.Level_End = 16;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 4 World 3")
        {
            gameManager.Level_End = 17;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 5 World 3")
        {
            gameManager.Level_End = 18;
            animation.SetBool("End", true);
            StartCoroutine(BackMap());
        } else if (other.name == "Complete Level 6 World 3")
        {
            gameManager.Level_End = 19;
            animation.SetBool("End", true);
            StartCoroutine(SaveFriend3());
        }
    }

    IEnumerator BackMap ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scenes/Map/Carte", LoadSceneMode.Single);
    }
    IEnumerator SaveFriend1 ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scenes/Map/Find Friend 1", LoadSceneMode.Single);
    }

    IEnumerator SaveFriend2 ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scenes/Map/Find Friend 2", LoadSceneMode.Single);
    }

    IEnumerator SaveFriend3 ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Scenes/Map/Find Friend 3", LoadSceneMode.Single);
    }
}
