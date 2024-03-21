using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Weapon[] slots;

    // an Array

    private void Start()
    {
        foreach (Weapon weapon in slots)
        {
            weapon.Attack();
        }

        slots[0].Attack();
    }


}
