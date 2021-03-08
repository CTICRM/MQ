using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Shows/Hides the compass image found in Tracker

public class ShowHideCompass : MonoBehaviour
{
	GameObject compass;
	public GameObject compassActive;
    // Start is called before the first frame update
    void Start()
    {
		compass = GameObject.Find("Compass Image");
    }
	
	// If the compass's activeSelf is true, it turns the
	// compass, as well as the active icon, off; else, it
	// turns both of them on
	public void compassVisibility() {
		if (compass.activeSelf == true) {
			compass.SetActive(false);
			compassActive.SetActive(false);
		}
		else {
			compass.SetActive(true);
			compassActive.SetActive(true);
		}
	}
}
