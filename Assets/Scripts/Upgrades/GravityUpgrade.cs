using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityUpgrade : BaseUpgrade
{
    protected PlaneController planeController;
    private float upgradeGravity;

    public GravityUpgrade(PlaneController plane, int upgradeCost, float newGravity)
    {
        planeController = plane;
        cost = upgradeCost;
        upgradeGravity = newGravity;
    }

    public override void ApplyUpgrade()
    {
        planeController.gravity -= upgradeGravity;
        planeController.gravity = Mathf.Clamp(planeController.gravity, 0f, 20f);
    }

    public override string UpgradeName()
    {
        return $"Speed {upgradeGravity}";
    }
}
