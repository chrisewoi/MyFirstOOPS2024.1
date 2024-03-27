using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/Powerup")]
public class Powerup : ScriptableObject
{
    [SerializeField] private float boost = 100;

    public virtual void UsePowerup(Rigidbody rb)
    {
        Debug.Log("POWER!!!");

        rb.AddRelativeForce(Vector3.forward * boost, ForceMode.VelocityChange);
    }
}
