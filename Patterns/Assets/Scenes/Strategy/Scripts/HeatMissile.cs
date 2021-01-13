using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatMissile : Missile
{
    public HeatMissile()
    {
        range = 15;
        damage = 70;
        behaviour = new HeatBehaviour();
    }
}
