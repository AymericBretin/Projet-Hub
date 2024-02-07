using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindFriend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void End()
    {
        SceneManager.LoadScene("Scenes/Map/Carte", LoadSceneMode.Single);
    }
}
