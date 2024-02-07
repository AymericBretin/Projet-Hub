using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BasicTile, HellTile;
    public Transform StartPos;
    public GameObject Player;
    public GameObject FondBasic, FondHell;
    public GameObject Flag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndFight()
    {
        HellTile.SetActive(false);
        BasicTile.SetActive(true);
        FondHell.SetActive(false);
        FondBasic.SetActive(true);
        Flag.SetActive(true);
        Player.transform.position = StartPos.position;
    }
}
