using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "jump", menuName = "Powerup/Jump")]
public class JumpPowerup : Powerup
{
    public float jump = 10;
    public override void UsePowerup(Rigidbody rb)
    {
        rb.AddForce(Vector3.up * jump, ForceMode.VelocityChange);
    }
}
