using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public StartGame startGame;
    public GameObject pauseMenu;
    
    void Update()
    {
        startGame = FindObjectOfType<StartGame>();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        Debug.Log("Pause");
        if (startGame != null) {
            startGame.start = false;
        }
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void Resume()
    {
        Debug.Log("Resume");
        if (startGame != null) {
            startGame.start = true;
        }
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }

    public void MainMenu()
    {
        Debug.Log("MainMenu");
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
        SceneManager.LoadScene("Scenes/Menu/Menu", LoadSceneMode.Single);
    }

    public void WorldLevel()
    {
        Debug.Log("WorldLevel");
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
        SceneManager.LoadScene("Scenes/Map/Carte", LoadSceneMode.Single);
    }
}
