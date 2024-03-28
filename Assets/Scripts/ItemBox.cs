using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : TriggerZone
{
    public Powerup powerup;

    public override void Activate(Collider other)
    {
        powerup.UsePowerup(other.attachedRigidbody);
    }
   
}
