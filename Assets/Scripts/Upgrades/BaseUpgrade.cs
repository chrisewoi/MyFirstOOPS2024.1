using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUpgrade
{
    protected int cost = 1;

    public abstract void ApplyUpgrade();
}
