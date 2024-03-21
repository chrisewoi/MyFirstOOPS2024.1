using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 10;
    public float weight;

    public virtual void Attack()
    {
        Debug.Log("Deal " + damage + " damage");
    }
}
