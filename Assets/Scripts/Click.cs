using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    //Displays the amount of gold the player has
    public UnityEngine.UI.Text goldDisplay;

    //Amount of gold
    public float gold = 0;

    //Gold per button click
    public int goldPerClick = 1;

    // Use this for initialization
    public void Clicked()
    {
        //On click add gold per click
        gold += goldPerClick;
    }

    // Update is called once per frame
    void Update()
    {
        //update text
        goldDisplay.text = "Gold: " + gold.ToString("F0");
    }
}
