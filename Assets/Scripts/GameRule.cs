using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRule : MonoBehaviour
{
    public GameObject looseScreen;
    public GameObject winScreen;
    public GameObject playerCtrl;

    GameObject[] ExitCorridorsL;
    GameObject[] ExitCorridorsR;

    private void Awake()
    {
        //ExitCorridorsL = GameObject.FindGameObjectsWithTag("CorridorL");
        //ExitCorridorsR = GameObject.FindGameObjectsWithTag("CorridorR");
    }

    private void Start()
    {
        //looseScreen = GameObject.FindGameObjectWithTag("Loose");
        //winScreen = GameObject.FindGameObjectWithTag("Win");
        ExitCorridorsL = GameObject.FindGameObjectsWithTag("CorridorL");
        ExitCorridorsR = GameObject.FindGameObjectsWithTag("CorridorR");
        playerCtrl = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        foreach(GameObject corridorL in ExitCorridorsL)
        {
            if (corridorL.name == "CorridorExitL")
            {
                if (corridorL.GetComponent<CorridorExit>().loose)
                    Loose();
                if (corridorL.GetComponent<CorridorExit>().win)
                    Win();
            }
        }
        foreach (GameObject corridorR in ExitCorridorsR)
        {
            if (corridorR.name == "CorridorExitR")
            {
                if (corridorR.GetComponent<CorridorExit>().loose)
                    Loose();
                if (corridorR.GetComponent<CorridorExit>().win)
                    Win();
            }
        }
    }

    private void Loose()
    {
        playerCtrl.GetComponent<PlayerController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        looseScreen.SetActive(true);
    }

    private void Win()
    {
        playerCtrl.GetComponent<PlayerController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        winScreen.SetActive(true);
    }
}
