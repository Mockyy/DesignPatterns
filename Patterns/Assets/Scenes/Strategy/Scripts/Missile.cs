using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    protected int range = 1;
    protected int damage = 10;
    protected ISeekBehaviour behaviour = default;

    public void LaunchMissile()
    {
        behaviour?.Behave();
    }
}
