using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scale : MonoBehaviour
{

    // Scales HUD elements down if Sensor is selected
    // to fit inside MTS menus

    private RectTransform rt;
    private Vector3 pilotSelected;
    private Vector3 sensorSelected;

    void Start()
    {
        // Store size of game object 
        rt = GetComponent<RectTransform>();

        // HUD elements fully scaled (Pilot)
        pilotSelected = new Vector3(1, 1, 1);

        // HUD elements scaled down to fit inside MTS Toolbar (SO)
        sensorSelected = new Vector3(.87f, .87f, 1);

    }
    public void SensorSelected()
    {
        // scaled
        rt.localScale = sensorSelected;

    }
    public void PilotSelected()
    {
        // full 
        rt.localScale = pilotSelected;
    }

}

