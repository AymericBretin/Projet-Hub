using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PressStart()
    {
        StartCoroutine(myCoroutine());
    }
    IEnumerator myCoroutine ()
    {
        SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
    }
}
