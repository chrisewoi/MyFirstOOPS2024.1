using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private int money = 0;
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private Transform buttonParent;
    private PlaneController planeController;
    private List<BaseUpgrade> upgrades;

    void Start()
    {
        planeController = FindObjectOfType<PlaneController>();


        upgrades = new List<BaseUpgrade>();
        upgrades.Add(new SpeedUpgrade(planeController, 5, 500f));
        upgrades.Add(new SpeedUpgrade(planeController, 5, 1000f));
        upgrades.Add(new SpeedUpgrade(planeController, 5, 1500f));
        upgrades.Add(new SpeedUpgrade(planeController, 5, 2000f));
        upgrades.Add(new GravityUpgrade(planeController, 5, 0.5f));
        upgrades.Add(new GravityUpgrade(planeController, 8, 1f));
        upgrades.Add(new GravityUpgrade(planeController, 12, 1.5f));
        upgrades.Add(new GravityUpgrade(planeController, 15, 2f));

        int x = 0;
        foreach(var upgrade in upgrades)
        {
            Button go = Instantiate(buttonPrefab, buttonParent);
            TMP_Text text = go.GetComponentInChildren<TMP_Text>();
            text.text = upgrade.UpgradeName();
            int y = x;
            go.onClick.AddListener( () => PurchaseUpgrade(y));
            x++;
        }


    }

    public void PurchaseUpgrade(int index)
    {
        if (upgrades[index].PayForUpgrade(ref money))
        {
            upgrades[index].ApplyUpgrade();
        }
    }
}
