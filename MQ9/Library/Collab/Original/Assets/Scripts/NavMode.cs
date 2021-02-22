using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavMode : MonoBehaviour
{
	public Button navMode;
	Color32 operationalColor = new Color32(0, 255, 3, 255);
	Color32 standardColor = new Color32(207, 207, 207, 255);
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
		navMode.GetComponent<Image>().color = standardColor;
		navModeBackgroundColor.GetComponent<Image>().color = standardColor;
		navModeDataText.GetComponent<Text>().text = "Off";
		navModeConfirmPopup.SetActive(false);
		navModePopup.SetActive(true);
	}
}
