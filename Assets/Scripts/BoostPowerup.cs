using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "boost", menuName = "Powerup/Boost")]
public class BoostPowerup : Powerup
{
    public override void UsePowerup(Rigidbody rb)
    {
        base.UsePowerup(rb);

        Debug.Log("This is boost class");
    }
}
