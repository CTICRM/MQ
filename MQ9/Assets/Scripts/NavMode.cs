using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Deals with turning Nav Mode on and off

public class NavMode : MonoBehaviour
{
	public Button navMode;
	Color32 operationalColor = new Color32(0, 255, 3, 255); // Nav Mode is on
	Color32 standardColor = new Color32(183, 183, 183, 255); // Nav Mode is off
	public GameObject navModeConfirmPopup;
	public GameObject navModePopup;
	public Text navModeDataText;
	public Image navModeBackgroundColor;
	bool isOn;
    // Start is called before the first frame update
    void Start()
    {
		navMode.GetComponent<Image>().color = operationalColor;
        navModeBackgroundColor.GetComponent<Image>().color = operationalColor;
		navModeDataText.GetComponent<Text>().text = "Operational";
    }
	
	// Updates the isOn variable depending on which of the on/off colors is being used
	void Update() {
		if (navModeBackgroundColor.GetComponent<Image>().color == operationalColor) {
			isOn = true;
		}
		else {
			isOn = false;
		}
	}
	
    public void turnOnConfirm() {
		if (isOn == true) {
			navModeConfirmPopup.SetActive(true);
		}
		else if (isOn == false) {
			navMode.GetComponent<Image>().color = operationalColor;
			navModeBackgroundColor.GetComponent<Image>().color = operationalColor;
			navModeDataText.GetComponent<Text>().text = "Operational";
		}
	}
	
	public void turnOffNavMode() {
		navMode.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
		navModeBackgroundColor.GetComponent<Image>().color = standardColor;
		navModeDataText.GetComponent<Text>().text = "Off";
		navModeConfirmPopup.SetActive(false);
		navModePopup.SetActive(true);
	}
}
