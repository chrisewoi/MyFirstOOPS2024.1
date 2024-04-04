using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    private int money = 0;

    private PlaneController planeController;
    private SpeedUpgrade upgrade;

    void Start()
    {
        planeController = FindObjectOfType<PlaneController>();
        
        upgrade = new SpeedUpgrade(planeController, 5);
    }

    public void PurchaseUpgrade()
    {
    }
}
