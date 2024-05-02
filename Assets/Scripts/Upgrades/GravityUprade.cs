using UnityEngine;

public class GravityUprade : BaseUpgrade
{
    protected PlaneController planeController;
    private float upgradeGravity;
    
    public GravityUprade(PlaneController plane, int upgradeCost, float newGravity)
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
}
