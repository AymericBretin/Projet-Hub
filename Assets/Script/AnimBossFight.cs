using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBossFight : MonoBehaviour
{
    public BossFight bossFight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndAnim()
    {
        Debug.Log("New");
        bossFight.NewNumber();
    }
}
