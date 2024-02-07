using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] scenePaths;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Door Boss 1")
        {
            SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
        } else if (other.name == "Door Boss 2")
        {
            SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
        } else if (other.name == "Door Boss 3")
        {
            SceneManager.LoadScene(scenePaths[2], LoadSceneMode.Single);
        }
    }
}
