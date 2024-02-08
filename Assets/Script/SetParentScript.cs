using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParentScript : MonoBehaviour
{
    public GameObject Grav;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Grav.transform.SetParent(Player.transform);
    }
}
