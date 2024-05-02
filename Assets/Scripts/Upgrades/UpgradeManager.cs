using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private int money = 0;

    private PlaneController planeController;
   // private SpeedUpgrade upgrade;
    //private GravityUprade upgrade2;

    private List<BaseUpgrade> upgrade;

    void Start()
    {
        planeController = FindObjectOfType<PlaneController>();
        
        upgrade = new List<BaseUpgrade>();
        upgrade.Add(new SpeedUpgrade(planeController, 5, 500f));
        upgrade.Add(new SpeedUpgrade(planeController, 8, 1000f));
        upgrade.Add(new SpeedUpgrade(planeController, 12, 1500f));
        upgrade.Add(new SpeedUpgrade(planeController, 15, 2000f));
        upgrade.Add(new GravityUprade(planeController, 5, 0.5f));
        upgrade.Add(new GravityUprade(planeController, 8, 1f));
        upgrade.Add(new GravityUprade(planeController, 12, 1.5f));
        upgrade.Add(new GravityUprade(planeController, 15, 2f));
    }

    public void PurchaseUpgrade(int index)
    {
        if (upgrade[index].PayForUpgrade(ref money))
        {
            upgrade[index].ApplyUpgrade();
        }

    }
}
