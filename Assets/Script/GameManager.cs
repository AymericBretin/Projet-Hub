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
        StartCoroutine(GoCinematique());
    }
    IEnumerator GoCinematique ()
    {
        SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
    }
}
