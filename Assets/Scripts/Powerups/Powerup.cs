using UnityEngine;

public abstract class Powerup : ScriptableObject 
{
    public abstract void UsePowerup(Rigidbody rb);
}
