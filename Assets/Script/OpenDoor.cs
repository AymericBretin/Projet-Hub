using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] scenePaths;
    public bool Door1;
    public bool Door2;
    public bool Door3;
    public GameObject GameManager;
    public Animator GameAnimator;
    public GameObject Text;
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        if (GameManager != null) {
                GameAnimator = GameManager.GetComponent<Animator>();
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (Door1 == true && Input.GetButtonDown("Jump")) {
            Door1 = false;
            GameAnimator.SetBool("Enter", true);
            StartCoroutine(Timer());
        }
        if (Door2 == true && Input.GetButtonDown("Jump")) {
            Door2 = false;
            GameAnimator.SetBool("Enter", true);
            StartCoroutine(Timer1());
        }
        if (Door3 == true && Input.GetButtonDown("Jump")) {
            Door3 = false;
            GameAnimator.SetBool("Enter", true);
            StartCoroutine(Timer2());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Door Boss 1")
        {
            Text.SetActive(true);
            Door1 = true;
        } else if (other.name == "Door Boss 2")
        {
            Text.SetActive(true);
            Door2 = true;
        } else if (other.name == "Door Boss 3")
        {
            Text.SetActive(true);
            Door3 = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Door Boss 1")
        {
            Text.SetActive(false);
            Door1 = false;
        } else if (other.name == "Door Boss 2")
        {
            Text.SetActive(false);
            Door2 = false;
        } else if (other.name == "Door Boss 3")
        {
            Text.SetActive(false);
            Door3 = false;
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.5f);
        GameAnimator.SetBool("Enter", false);
        SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
    }
    IEnumerator Timer1()
    {
        yield return new WaitForSeconds(1.5f);
        GameAnimator.SetBool("Enter", false);
        SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
    }
    IEnumerator Timer2()
    {
        yield return new WaitForSeconds(1.5f);
        GameAnimator.SetBool("Enter", false);
        SceneManager.LoadScene(scenePaths[2], LoadSceneMode.Single);
    }
}
