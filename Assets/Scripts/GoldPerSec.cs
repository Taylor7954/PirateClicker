using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPerSec : MonoBehaviour {

    public UnityEngine.UI.Text gpsDisplay;
    public Click click;
    public PirateCrew[] crew;
    private PirateShips shipType;

    public float getGPS()
    {
        float tick = 0;
        foreach (PirateCrew pirate in crew)
        {
            tick += pirate.count * pirate.tickValue;
        }
        //tick = shipType.getTickBonus(tick);
        return tick;
    }

    public void AutoGPS()
    {
        click.gold += getGPS()/10;
    }

    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGPS();
            yield return new WaitForSeconds(0.10f);
        }
    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine(AutoTick());
    }

    // Update is called once per frame
    void Update()
    {
        gpsDisplay.text = getGPS() + " gold/sec";
    }
}
