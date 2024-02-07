using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPhaseBossWorld3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BackGroundBasic;
    public GameObject BackGroundHell;
    public GameObject ShadowHealth;
    public GameObject ShadowVesselHealth;
    public GameObject BodyBasic;
    public GameObject BodyHell;
    public GameObject Player;
    public Transform pos1;
    public BossFight bossFight;
    void Start()
    {
        bossFight = FindObjectOfType<BossFight>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBG()
    {
        bossFight.Phase = 1;
        BodyBasic.SetActive(false);
        BodyHell.SetActive(true);
        BackGroundBasic.SetActive(false);
        BackGroundHell.SetActive(true);
        Player.transform.position = pos1.position;
    }

    public void HideHealth()
    {
        ShadowHealth.SetActive(false);
    }

    public void ShowHealth()
    {
        ShadowVesselHealth.SetActive(true);
        bossFight.NewNumber();
    }
}
