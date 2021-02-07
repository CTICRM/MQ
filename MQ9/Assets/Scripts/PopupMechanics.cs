using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMechanics : MonoBehaviour
{
	public GameObject configObject;
	public GameObject trackerObject;
	public GameObject HUD_Object;
	public GameObject statusScreenObject;
	public GameObject commandScreenObject;
	public GameObject SMS_Object;
	public GameObject MFD_Object;
	public Button configButton;
	public Button okButton;
	public Button pilotButton;
	public Button SO_Button;
	public Button tracker;
	public Button HUD;
	public Button statusScreen;
	public Button commandScreen;
	public Button SMS;
	public Button MFD;
	public Image trackerButtonBackground;
	public Image HUD_ButtonBackground;
	public Image statusScreenButtonBackground;
	public Image commandScreenButtonBackground;
	public Image SMS_ButtonBackground;
	public Image MFD_ButtonBackground;
	GameObject inGameToggle;
	Color selectedColor = new Color32(0, 34, 255, 255);
	
	public void openConfig() {
		configObject.SetActive(true);
		trackerObject.SetActive(false);
		HUD_Object.SetActive(false);
		statusScreenObject.SetActive(false);
		commandScreenObject.SetActive(false);
		SMS_Object.SetActive(false);
		MFD_Object.SetActive(false);
		pilotButton.GetComponent<Button>().interactable = false;
		SO_Button.GetComponent<Button>().interactable = false;
		tracker.GetComponent<Button>().interactable = false;
		HUD.GetComponent<Button>().interactable = false;
		statusScreen.GetComponent<Button>().interactable = false;
		commandScreen.GetComponent<Button>().interactable = false;
		SMS.GetComponent<Button>().interactable = false;
		MFD.GetComponent<Button>().interactable = false;
		inGameToggle = GameObject.Find("Toggle");
	}
	
    // Start is called before the first frame update
    void Start()
    {
		Button ok = okButton.GetComponent<Button>();
		ok.onClick.AddListener(closeConfig);
        configObject.SetActive(false);
		trackerObject.SetActive(true);
		HUD_Object.SetActive(false);
		statusScreenObject.SetActive(false);
		commandScreenObject.SetActive(false);
		SMS_Object.SetActive(false);
		MFD_Object.SetActive(false);
    }
	
	void closeConfig() {
		configObject.SetActive(false);
		pilotButton.GetComponent<Button>().interactable = true;
		SO_Button.GetComponent<Button>().interactable = true;
		tracker.GetComponent<Button>().interactable = true;
		HUD.GetComponent<Button>().interactable = true;
		statusScreen.GetComponent<Button>().interactable = true;
		commandScreen.GetComponent<Button>().interactable = true;
		SMS.GetComponent<Button>().interactable = true;
		MFD.GetComponent<Button>().interactable = true;
		bool isChecked = inGameToggle.GetComponent<Toggle>().isOn;
		if (isChecked == true) {
			configButton.GetComponent<Button>().interactable = false;
		}
		if (trackerButtonBackground.GetComponent<Image>().color == selectedColor) {
			trackerObject.SetActive(true);
		}
		if (HUD_ButtonBackground.GetComponent<Image>().color == selectedColor) {
			HUD_Object.SetActive(true);
		}
		if (statusScreenButtonBackground.GetComponent<Image>().color == selectedColor) {
			statusScreenObject.SetActive(true);
		}
		if (commandScreenButtonBackground.GetComponent<Image>().color == selectedColor) {
			commandScreenObject.SetActive(true);
		}
		if (SMS_ButtonBackground.GetComponent<Image>().color == selectedColor) {
			SMS_Object.SetActive(true);
		}
		if (MFD_ButtonBackground.GetComponent<Image>().color == selectedColor) {
			MFD_Object.SetActive(true);
		}
	}
}
