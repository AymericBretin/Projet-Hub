using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveIdle : MonoBehaviour
{
    public Animator Dino1;
    public Animator Dino2;
    public Animator Dino3;
    public Animator Dino4;
    public string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
                End();
        }
    }

    void SetIdle()
    {
        Dino1.SetBool("Idle", true);
        Dino2.SetBool("Idle", true);
        Dino3.SetBool("Idle", true);
        Dino4.SetBool("Idle", true);
    }

    void RmIdle()
    {
        Dino1.SetBool("Idle", false);
    }

    public void End()
    {
        SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
    }
}
