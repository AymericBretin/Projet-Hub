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
        startGame.start = false;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void Resume()
    {
        startGame.start = true;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }

/*    public void loadmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }*/
}
