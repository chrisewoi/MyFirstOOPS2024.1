using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : TriggerZone
{
    public Powerup powerup;

    public override void Activate(Collider other)
    {
        Debug.Log("Activated ItemBox");

        powerup.UsePowerup(other.attachedRigidbody);
    }
   
}
