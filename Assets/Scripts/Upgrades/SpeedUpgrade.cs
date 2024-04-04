using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpgrade : BaseUpgrade 
{
    protected PlaneController planeController;

    public SpeedUpgrade(PlaneController plane)
    {
        planeController = plane;
    }

    //overloading
    //constructors
    public SpeedUpgrade(PlaneController plane, int upgradeCost)
    {
        planeController = plane;
        cost = upgradeCost;
    }
    
    public override void ApplyUpgrade()
    {
             
    }

}
