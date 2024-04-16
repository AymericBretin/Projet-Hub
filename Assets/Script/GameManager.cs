using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string[] scenePaths;
    public MoveOnMap moveOnMap;
    public GameObject playerMap;
    public GameObject player;
    public int Level_End = 1;
    public int world = 1;
    public int TimeSecond = 0;
    public int TimeMinute = 0;
    public bool InGame = false;
    public bool Training = false;
    public GameObject Menu, Menu2;
    public GameObject GameSelection;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerMap = GameObject.Find("PlayerMap");
        moveOnMap = FindObjectOfType<MoveOnMap>();
        DontDestroyOnLoad(gameObject);
    }

    public void PressStart()
    {
        Menu.SetActive(false);
        Menu2.SetActive(false);
        if (Level_End == 1) {
            GameSelection.SetActive(true);
        } else {
            SceneManager.LoadScene(scenePaths[2], LoadSceneMode.Single);
        }
    }

    public void CampaignStart()
    {
        InGame = true;
        StartCoroutine(IGTimer());
        if (Level_End == 1) {
            StartCoroutine(GoCinematique());
        } else {
            SceneManager.LoadScene(scenePaths[2], LoadSceneMode.Single);
        }
    }

    public void TrainingStart()
    {
        InGame = true;
        StartCoroutine(IGTimer());
        Training = true;
        if (Level_End == 1) {
            StartCoroutine(GoCinematique());
        } else {
            SceneManager.LoadScene(scenePaths[2], LoadSceneMode.Single);
        }
    }
    IEnumerator GoCinematique ()
    {
        SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
    }

    IEnumerator IGTimer ()
    {
        yield return new WaitForSeconds(1);
        TimeSecond += 1;
        if (TimeSecond == 60) {
            TimeSecond = 0;
            TimeMinute += 1;
        }
        if (InGame == true) {
            StartCoroutine(IGTimer());
        }
    }
}
