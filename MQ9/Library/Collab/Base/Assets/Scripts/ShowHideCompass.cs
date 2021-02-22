using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHideCompass : MonoBehaviour
{
	GameObject compass;
	public GameObject compassActive;
    // Start is called before the first frame update
    void Start()
    {
		compass = GameObject.Find("Compass Image");
    }
	
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
