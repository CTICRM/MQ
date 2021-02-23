using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LynxSARControls : MonoBehaviour
{
	public Button power;
	public Button transmitter;
	public Button operation;
	public GameObject operationOptions;
	public InputField gmtiParamsLatitude;
	public InputField gmtiParamsLongitude;
	public InputField gmtiParamsElevation;
	public Button fromRadar;
	public InputField sweepAngle;
	public InputField rangeRes;
	public Button arc;
	public Button spot;
	public Button clear;
	public Button rain;
	public InputField minRCS;
	public InputField minSNR;
	public InputField minDetVel;
	public InputField maxTargets;
	public Button mosp;
	public Button rcs;
	public InputField ddiImpressionCoordinates;
	public Button mirror;
	public Button finish;
	public InputField groundTrackAnglesOne;
	public InputField groundTrackAnglesTwo;
	public InputField groundTrackAnglesThree;
	public InputField ddiName;
	public InputField ddiLatitude;
	public InputField ddiLongitude;
	public InputField ddiElevation;
	public InputField genericTargetCoordinates;
	public InputField gpsTimeStamp;
	public InputField genTarLatitude;
	public InputField genTarLongitude;
	public InputField genTarElevation;
	Color32 onGreen = new Color32(66, 214, 73, 255);
	Color32 onBlack = new Color32(0, 0, 0, 255);
	Color32 offGray = new Color32(207, 207, 207, 255);
	Color32 offWhite = new Color32(255, 255, 255, 255);
	
	// Start is called before the first frame update
    void Start()
    {
		gmtiParamsLatitude.text = "00 00 00 N";
		gmtiParamsLongitude.text = "000 00 00 E";
		gmtiParamsElevation.text = "0";
		sweepAngle.text = "0";
		rangeRes.text = "10";
		minRCS.text = "0";
		minSNR.text = "20";
		minDetVel.text = "2";
		maxTargets.text = "1000";
		mosp.GetComponentInChildren<Text>().text = "OFF";
		rcs.GetComponentInChildren<Text>().text = "Manual";
		ddiImpressionCoordinates.text = "00.00.00 N.   000.00.00 E.   0000.00 m";
		mirror.GetComponentInChildren<Text>().text = "Mirror";
		finish.GetComponentInChildren<Text>().text = "Far";
		groundTrackAnglesOne.text = "000";
		groundTrackAnglesTwo.text = "000";
		groundTrackAnglesThree.text = "000";
		ddiName.text = "17345864A45EF154";
		ddiLatitude.text = "000.000000 N";
		ddiLongitude.text = "000.000000 E";
		ddiElevation.text = "000.000000 m";
		genericTargetCoordinates.text = "00.00.00 N.   000.00.00 E.   0000.00 m";
		gpsTimeStamp.text = "???  ?? ?? ??";
		genTarLatitude.text = "000.00000 N";
		genTarLongitude.text = "000.00000 E";
		genTarElevation.text = "000.00000 m";
    }

    // Update is called once per frame
    void Update()
    {
        if (power.GetComponentInChildren<Text>().text == "On" && transmitter.GetComponentInChildren<Text>().text == "Enabled") {
			operationOptions.SetActive(true);
		}
		else {
			operationOptions.SetActive(false);
		}
    }
	
	public void powerClick() {
		if (power.GetComponentInChildren<Text>().text == "Off") {
			power.GetComponentInChildren<Text>().text = "On";
			power.GetComponent<Image>().color = onGreen;
			transmitter.interactable = true;
		}
		else {
			power.GetComponentInChildren<Text>().text = "Off";
			power.GetComponent<Image>().color = offGray;
			transmitter.interactable = false;
			transmitter.GetComponent<Image>().color = offGray;
			transmitter.GetComponentInChildren<Text>().text = "Disabled";
		}
	}
	
	public void transmitterClick() {
		if (transmitter.GetComponentInChildren<Text>().text == "Disabled") {
			transmitter.GetComponentInChildren<Text>().text = "Enabled";
			transmitter.GetComponent<Image>().color = onGreen;
			operationOptions.SetActive(true);
		}
		else {
			transmitter.GetComponentInChildren<Text>().text = "Disabled";
			transmitter.GetComponent<Image>().color = offGray;
			operationOptions.SetActive(false);
		}
	}
	
	public void fromRadarClick() {
		if (fromRadar.GetComponent<Image>().color == offWhite) {
			fromRadar.GetComponent<Image>().color = onBlack;
		}
		else {
			fromRadar.GetComponent<Image>().color = offWhite;
		}
	}
	
	public void arcClick() {
		arc.GetComponent<Image>().color = onBlack;
		spot.GetComponent<Image>().color = offWhite;
	}
	
	public void spotClick() {
		arc.GetComponent<Image>().color = offWhite;
		spot.GetComponent<Image>().color = onBlack;
	}
	
	public void clearClick() {
		clear.GetComponent<Image>().color = onBlack;
		rain.GetComponent<Image>().color = offWhite;
	}
	
	public void rainClick() {
		clear.GetComponent<Image>().color = offWhite;
		rain.GetComponent<Image>().color = onBlack;
	}
	
	public void mospClick() {
		if (mosp.GetComponentInChildren<Text>().text == "OFF") {
			mosp.GetComponentInChildren<Text>().text = "ON";
		}
		else {
			mosp.GetComponentInChildren<Text>().text = "OFF";
		}
	}
	
	public void rcsClick() {
		if (rcs.GetComponentInChildren<Text>().text == "Manual") {
			rcs.GetComponentInChildren<Text>().text = "Auto";
		}
		else {
			rcs.GetComponentInChildren<Text>().text = "Manual";
		}
	}
	
	public void mirrorClick() {
		if (mirror.GetComponentInChildren<Text>().text == "Mirror") {
			mirror.GetComponentInChildren<Text>().text = "Normal";
		}
		else {
			mirror.GetComponentInChildren<Text>().text = "Mirror";
		}
	}
	
	public void finishClick() {
		if (finish.GetComponentInChildren<Text>().text == "Far") {
			finish.GetComponentInChildren<Text>().text = "Close";
		}
		else {
			finish.GetComponentInChildren<Text>().text = "Far";
		}
	}
}
