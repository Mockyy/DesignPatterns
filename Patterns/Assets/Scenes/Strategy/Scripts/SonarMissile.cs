using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarMissile : Missile
{
    public SonarMissile()
    {
        range = 20;
        damage = 50;
        behaviour = new SonarBehaviour();
    }
}
