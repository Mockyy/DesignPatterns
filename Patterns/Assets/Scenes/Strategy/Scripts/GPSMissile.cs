using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPSMissile : Missile
{
    public GPSMissile()
    {
        range = 100;
        damage = 20;
        behaviour = new GPSBehaviour();
    }
}
