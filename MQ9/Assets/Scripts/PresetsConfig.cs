using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresetsConfig : MonoBehaviour
{
	public InputField enterUAVNum;
	public Button gcsSystemCompatibility;
	public Button inFlightTrack;
	public InputField gdtAzimuthCommand;
	public InputField gdtAzimuthOffset;
	public InputField gdtUpFreq1;
	public InputField gdtUpFreq2;
	public InputField avDownFreq1;
	public InputField avDownFreq2;
	public Button gdtUplinkTxPower;
	public Button gdtUplinkTx1;
	public Button gdtUplinkTx2;
	public Button avDownTxPower;
	public Button avDownTx1;
	public Button avDownTx2;
	public Button avRxTx1;
	public Button gdtDishTx;
	public Button gdtDishTxDirectOnly;
	public Button gdtDishRxSelection;
	public Button lmaNumber;
	public InputField barometricPressure;
	public InputField fieldElevation;
	public InputField gdtElevation;
	public InputField gdtLatitude;
	public InputField gdtLongitude;
	public InputField stssElevation;
	public InputField stssLatitude;
	public InputField stssLongitude;
	public InputField initialLostLinkAltitude;
	public InputField initialLostLinkHeading;
	public InputField missionSequenceNum;
	public InputField lightsOnRange;
	public InputField fuelAtStartOfFlight;
	public InputField jokerFuelLevel;
	public InputField bingoFuelLevel;
	public InputField magneticVariation;
	public InputField avRampWeight;
	public InputField minAltitudeMSL;
	public Button hudAltitudeDisplay;
	public InputField noseLensHeat;
	public InputField iffMode3ACode;
	public InputField gpsMissionTime;
	public InputField chartRecorderConfig;
    // Start is called before the first frame update
    void Start()
    {
        enterUAVNum.text = "00027";
		gdtAzimuthCommand.text = "170";
		gdtAzimuthOffset.text = "000";
		gdtUpFreq1.text = "5710";
		gdtUpFreq2.text = "5790";
		avDownFreq1.text = "535";
		avDownFreq2.text = "5455";
		barometricPressure.text = "29.92";
		fieldElevation.text = "3134";
		gdtElevation.text = "3137";
		gdtLatitude.text = "36 35 25 N";
		gdtLongitude.text = "115 41 40 W";
		stssElevation.text = "0";
		stssLatitude.text = "00 00 00 N";
		stssLongitude.text = "000 00 00 W";
		initialLostLinkAltitude.text = "4143";
		initialLostLinkHeading.text = "360";
		missionSequenceNum.text = "23";
		lightsOnRange.text = "60";
		fuelAtStartOfFlight.text = "2800";
		jokerFuelLevel.text = "500";
		bingoFuelLevel.text = "500";
		magneticVariation.text = "10";
		avRampWeight.text = "8026";
		minAltitudeMSL.text = "11300";
		noseLensHeat.text = "30";
		iffMode3ACode.text = "270";
		gpsMissionTime.text = "0";
		chartRecorderConfig.text = "35";
    }
	
	public void gcsSystemCompatibilityClick() {
		if (gcsSystemCompatibility.GetComponentInChildren<Text>().text == "System A") {
			gcsSystemCompatibility.GetComponentInChildren<Text>().text = "System B";
		}
		else if (gcsSystemCompatibility.GetComponentInChildren<Text>().text == "System B") {
			gcsSystemCompatibility.GetComponentInChildren<Text>().text = "System C";
		}
		else {
			gcsSystemCompatibility.GetComponentInChildren<Text>().text = "System A";
		}
	}
	
	public void inFlightTrackClick() {
		if (inFlightTrack.GetComponentInChildren<Text>().text == "ON") {
			inFlightTrack.GetComponentInChildren<Text>().text = "OFF";
		}
		else {
			inFlightTrack.GetComponentInChildren<Text>().text = "ON";
		}
	}
	
	public void gdtUplinkTxPowerClick() {
		if (gdtUplinkTxPower.GetComponentInChildren<Text>().text == "HIGH") {
			gdtUplinkTxPower.GetComponentInChildren<Text>().text = "LOW";
		}
		else {
			gdtUplinkTxPower.GetComponentInChildren<Text>().text = "HIGH";
		}
	}
	
	public void gdtUplinkTx1Click() {
		if (gdtUplinkTx1.GetComponentInChildren<Text>().text == "OFF") {
			gdtUplinkTx1.GetComponentInChildren<Text>().text = "ON";
		}
		else {
			gdtUplinkTx1.GetComponentInChildren<Text>().text = "OFF";
		}
	}
	
	public void gdtUplinkTx2Click() {
		if (gdtUplinkTx2.GetComponentInChildren<Text>().text == "OFF") {
			gdtUplinkTx2.GetComponentInChildren<Text>().text = "ON";
		}
		else {
			gdtUplinkTx2.GetComponentInChildren<Text>().text = "OFF";
		}
	}
	
	public void avDownTxPowerClick() {
		if (avDownTx1.GetComponentInChildren<Text>().text == "HIGH") {
			avDownTx1.GetComponentInChildren<Text>().text = "LOW";
		}
		else {
			avDownTx1.GetComponentInChildren<Text>().text = "HIGH";
		}
	}
	
	public void avDownTx1Click() {
		if (avDownTx1.GetComponentInChildren<Text>().text == "OFF") {
			avDownTx1.GetComponentInChildren<Text>().text = "ON";
		}
		else {
			avDownTx1.GetComponentInChildren<Text>().text = "OFF";
		}
	}
	
	public void avDownTx2Click() {
		if (avDownTx2.GetComponentInChildren<Text>().text == "OFF") {
			avDownTx2.GetComponentInChildren<Text>().text = "ON";
		}
		else {
			avDownTx2.GetComponentInChildren<Text>().text = "OFF";
		}
	}
	
	public void avRxTx1Click() {
		if (avRxTx1.GetComponentInChildren<Text>().text == "DIRECTIONAL") {
			avRxTx1.GetComponentInChildren<Text>().text = "OMNI";
		}
		else {
			avRxTx1.GetComponentInChildren<Text>().text = "DIRECTIONAL";
		}
	}
	
	public void gdtDishTxClick() {
		if (gdtDishTx.GetComponentInChildren<Text>().text == "DIRECTIONAL") {
			gdtDishTx.GetComponentInChildren<Text>().text = "OMNI";
		}
		else {
			gdtDishTx.GetComponentInChildren<Text>().text = "DIRECTIONAL";
		}
	}
	
	public void gdtDishTxDirectOnlyClick() {
		if (gdtDishTxDirectOnly.GetComponentInChildren<Text>().text == "WIDE") {
			gdtDishTxDirectOnly.GetComponentInChildren<Text>().text = "NARROW";
		}
		else {
			gdtDishTxDirectOnly.GetComponentInChildren<Text>().text = "WIDE";
		}
	}
	
	public void gdtDishRxSelectionClick() {
		if (gdtDishRxSelection.GetComponentInChildren<Text>().text == "Rx#1") {
			gdtDishRxSelection.GetComponentInChildren<Text>().text = "Rx#2";
		}
		else {
			gdtDishRxSelection.GetComponentInChildren<Text>().text = "Rx#1";
		}
	}
	
	public void lmaNumberClick() {
		if (lmaNumber.GetComponentInChildren<Text>().text == "1") {
			lmaNumber.GetComponentInChildren<Text>().text = "2";
		}
		else {
			lmaNumber.GetComponentInChildren<Text>().text = "1";
		}
	}
	
	public void hudAltitudeDisplayClick() {
		if (hudAltitudeDisplay.GetComponentInChildren<Text>().text == "MSL") {
			hudAltitudeDisplay.GetComponentInChildren<Text>().text = "AGL";
		}
		else {
			hudAltitudeDisplay.GetComponentInChildren<Text>().text = "MSL";
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
