using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/Jump")]
public class JumpPowerup : Powerup 
{
   public float boost = 10;

   public override void UsePowerup(Rigidbody rb)
   {
        rb.AddForce(Vector3.up * boost, ForceMode.VelocityChange);
   }
}
