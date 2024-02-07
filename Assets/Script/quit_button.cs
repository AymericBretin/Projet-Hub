using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit_button : MonoBehaviour
{
    public void quitgame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
