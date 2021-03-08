using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Deals with the different options users can select from the middle of
// the sidebar (Tracker, HUD, Status Screen, Command Screen, SMS, and MFD),
// as well as the different positions they can choose from the top of the
// sidebar (Pilot and SO)

public class ColorChange : MonoBehaviour
{
	public Button pilot;
	public Button so;
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
	public GameObject HUD_Left_Buttons;
	public GameObject HUD_Right_Buttons;
	public GameObject HUD_Top_Buttons;
	public GameObject HUD_Bottom_Buttons;
	public GameObject trackerCanvas;
	public GameObject HUD_Canvas;
	public GameObject statusScreenCanvas;
	public GameObject commandScreenCanvas;
	public GameObject SMS_Canvas;
	public GameObject MFD_Canvas;
	public Image Pilot_HUD_Image;
	public Image SO_HUD_Image;
	public Text stationTextField;
	public Text timeText;
	public Text timeZone;
	public Text soClock;
	DateTime saveUtcNow = DateTime.UtcNow;
    // Start is called before the first frame update
    void Start()
    {
        pilot.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
        so.GetComponent<Image>().color = new Color32(90, 90, 90, 255);
        trackerButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		Pilot_HUD_Image.enabled = true;
		SO_HUD_Image.enabled = false;
		HUD_Left_Buttons.SetActive(false);
		HUD_Right_Buttons.SetActive(false);
		HUD_Top_Buttons.SetActive(false);
		HUD_Bottom_Buttons.SetActive(false);
		stationTextField.text = "Pilot Station";
		timeText.GetComponent<Text>().enabled = true;
		timeZone.GetComponent<Text>().enabled = true;
		StartCoroutine(updateClock());
    }
	
	// Shows users the clock seen in HUD when SO is selected
	IEnumerator updateClock() {
		while (true) {
			saveUtcNow = saveUtcNow.AddSeconds(1);
			timeZone.text = saveUtcNow.ToString("HH:mm:ss");
			soClock.text = saveUtcNow.ToString("HH:mm:ss");
			yield return new WaitForSeconds(1);
		}
	}
	
	public void changePilotColor() {
		pilot.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
        so.GetComponent<Image>().color = new Color32(90, 90, 90, 255); 
		SMS.GetComponent<Button>().interactable = true;
		Pilot_HUD_Image.enabled = true;
		SO_HUD_Image.enabled = false;
		stationTextField.text = "Pilot Station";
		timeText.GetComponent<Text>().enabled = true;
		timeZone.GetComponent<Text>().enabled = true;
		HUD_Left_Buttons.SetActive(false);
		HUD_Right_Buttons.SetActive(false);
		HUD_Top_Buttons.SetActive(false);
		HUD_Bottom_Buttons.SetActive(false);
	}
	
	public void changeSOColor() {
        so.GetComponent<Image>().color = new Color32(41, 94, 135, 255);

        pilot.GetComponent<Image>().color = new Color32(90, 90, 90, 255);
        SMS.GetComponent<Button>().interactable = false;
		Pilot_HUD_Image.enabled = false;
		SO_HUD_Image.enabled = true;
		stationTextField.text = "Payload Station";
		timeText.GetComponent<Text>().enabled = false;
		timeZone.GetComponent<Text>().enabled = false;
		HUD_Left_Buttons.SetActive(true);
		HUD_Right_Buttons.SetActive(true);
		HUD_Top_Buttons.SetActive(true);
		HUD_Bottom_Buttons.SetActive(true);
	}
	
	public void trackerChosen() {
		trackerButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		trackerCanvas.SetActive(true);
		HUD_Canvas.SetActive(false);
		statusScreenCanvas.SetActive(false);
		commandScreenCanvas.SetActive(false);
		SMS_Canvas.SetActive(false);
		MFD_Canvas.SetActive(false);
	}
	
	public void HUD_Chosen() {
		trackerButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		trackerCanvas.SetActive(false);
		HUD_Canvas.SetActive(true);
		statusScreenCanvas.SetActive(false);
		commandScreenCanvas.SetActive(false);
		SMS_Canvas.SetActive(false);
		MFD_Canvas.SetActive(false);
	}
	
	public void statusScreenChosen() {
		trackerButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		trackerCanvas.SetActive(false);
		HUD_Canvas.SetActive(false);
		statusScreenCanvas.SetActive(true);
		commandScreenCanvas.SetActive(false);
		SMS_Canvas.SetActive(false);
		MFD_Canvas.SetActive(false);
	}
	
	public void commandScreenChosen() {
		trackerButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		trackerCanvas.SetActive(false);
		HUD_Canvas.SetActive(false);
		statusScreenCanvas.SetActive(false);
		commandScreenCanvas.SetActive(true);
		SMS_Canvas.SetActive(false);
		MFD_Canvas.SetActive(false);
	}
	
	public void SMS_Chosen() {
		trackerButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		trackerCanvas.SetActive(false);
		HUD_Canvas.SetActive(false);
		statusScreenCanvas.SetActive(false);
		commandScreenCanvas.SetActive(false);
		SMS_Canvas.SetActive(true);
		MFD_Canvas.SetActive(false);
	}
	
	public void MFD_Chosen() {
		trackerButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		HUD_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		statusScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		commandScreenButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		SMS_ButtonBackground.GetComponent<Image>().color = new Color32(63, 63, 63, 255);
		MFD_ButtonBackground.GetComponent<Image>().color = new Color32(41, 94, 135, 255);
		trackerCanvas.SetActive(false);
		HUD_Canvas.SetActive(false);
		statusScreenCanvas.SetActive(false);
		commandScreenCanvas.SetActive(false);
		SMS_Canvas.SetActive(false);
		MFD_Canvas.SetActive(true);
	}
}
