using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_attack_world_1 : MonoBehaviour
{
    public world_1_boss_attack boss_attack;
    void set_attack()
    {
        boss_attack.hit = true;
    }
    void set_attack_false()
    {
        boss_attack.hit = false;
    }
}
