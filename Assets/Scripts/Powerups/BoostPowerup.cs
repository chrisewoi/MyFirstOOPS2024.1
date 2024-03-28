using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/Boost")]
public class BoostPowerup : Powerup 
{
    public float boost = 10;
    
    public override void UsePowerup(Rigidbody rb)
    {
        rb.AddRelativeForce(Vector3.forward * boost, ForceMode.VelocityChange);
    }
}
