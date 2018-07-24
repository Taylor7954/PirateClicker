using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    public void CrewMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void ShipMenu()
    {
        SceneManager.LoadScene(3);
    }
}
