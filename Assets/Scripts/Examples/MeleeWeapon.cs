using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon
{
    public float reach;

    public override void Attack()
    {
        Debug.Log("Done " + damage + " dmg"
            + " with " + reach + " reach");
    }
}
