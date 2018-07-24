using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateShips : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public GoldPerSec gps;
    public float cost;
    public string shipType;
    private string ship;
    private float baseCost;
    public bool purchased;



    // Use this for initialization
    void Start()
    {
        baseCost = cost;
        ship = "row boat";
    }

    public float getShipTypeBonus()
    {
        if (ship == "sloop")
        {
            return 1f;
        }

        if (ship == "galleon")
        {
            return 2f;
        }
        else return 0;
    }

    public void purchasedItem()
    {
        if (!purchased && click.gold >= cost)
        {
            click.gold -= cost;
        }
    }
    public float getTickBonus(float tick)
    {
        float ship_bonus = getShipTypeBonus();
        float tick_bonus = tick + ship_bonus*tick;
        return tick_bonus;
    }

    public void UpgradeShip()
    {

    }

    public string getShipType()
    {
        return ship;
    }
    // Update is called once per frame
    void Update ()
    {
        if (purchased == true)
        {
            itemInfo.text = "PURCHASED!";
        }
        else
        {
            itemInfo.text = shipType + "\nCost: " + cost + "\nBonus: " + getShipTypeBonus();
        }
    }
}
