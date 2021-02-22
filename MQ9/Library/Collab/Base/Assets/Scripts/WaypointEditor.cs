using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointEditor : MonoBehaviour
{
	public InputField waypointNumber;
	public Button goLeft;
	public Button goRight;
	public Dropdown ddCoordinateSystem;
	public GameObject latLonSec;
	public InputField latSec;
	public InputField lonSec;
	public GameObject latLonMin;
	public InputField latMin;
	public InputField lonMin;
	public GameObject mgrs;
	public InputField mgrsInput;
	public GameObject utm;
	public InputField utmInput;
	public InputField altitude;
	public InputField airspeed;
	public Dropdown ddMonth;
	public InputField arrivalInputOne;
	public InputField arrivalInputTwo;
	public Dropdown ddLoiterPattern;
	public InputField lengthInput;
	public InputField widthInput;
	public InputField diameterInput;
	public InputField azimuthInput;
	public InputField loiterTimeInput;
	public InputField plannedRollLMTInput;
	public Button turnLeft;
	public Button turnRight;
	public Button lostLinkOK;
	public Button flyOverWP;
	public Button losTxOneInhibit;
	public Button losTxTwoInhibit;
	public InputField modeOne;
	public Button modeOneEnabled;
	public InputField modeTwo;
	public Button modeTwoEnabled;
	public InputField modeThreeAC;
	public Button modeThreeACEnabled;
	public Button modeFourCode;
	public Button modeFourEnabled;
	bool lostLinkOn = false;
	bool flyOverOn = false;
	bool losTxOneOn = false;
	bool losTxTwoOn = false;
	bool modeOneOn = false;
	bool modeTwoOn = false;
	bool modeThreeOn = true;
	bool modeFourOn = false;
	Color32 onColor = new Color32(0, 0, 0, 255);
	Color32 offColor = new Color32(207, 207, 207, 255);
	
	private void Start() {
		waypointNumber.text = "001";
		ddCoordinateSystem.onValueChanged.AddListener(delegate {
			ddCoordinateSystemValueChanged(ddCoordinateSystem);
		});
		latSec.text = "34 44 48 N";
		lonSec.text = "115 45 28 W";
		latMin.text = "36 44.8 N";
		lonMin.text = "115 45.47 W";
		mgrsInput.text = "11S PA 10896 67489";
		utmInput.text = "11N 610896 4067489";
		altitude.text = "24000";
		airspeed.text = "105";
		ddMonth.interactable = false;
		arrivalInputOne.text = "1";
		arrivalInputOne.interactable = false;
		arrivalInputTwo.text = "1";
		arrivalInputTwo.interactable = false;
		ddLoiterPattern.onValueChanged.AddListener(delegate {
			ddLoiterPatternValueChanged(ddLoiterPattern);
		});
		lengthInput.text = "5";
		lengthInput.interactable = false;
		widthInput.text = "5";
		widthInput.interactable = false;
		diameterInput.text = "5";
		diameterInput.interactable = false;
		azimuthInput.text = "0";
		azimuthInput.interactable = false;
		loiterTimeInput.text = "30";
		loiterTimeInput.interactable = false;
		plannedRollLMTInput.text = "5";
		plannedRollLMTInput.interactable = false;
		turnLeft.interactable = false;
		turnRight.interactable = false;
		modeOne.text = "00";
		modeTwo.text = "0000";
		modeThreeAC.text = "1200";
	}
	
	public void ddCoordinateSystemValueChanged(Dropdown sender) {
		if (sender.options[sender.value].text == "Lat/Lon Sec") {
			latLonSec.SetActive(true);
			latLonMin.SetActive(false);
			mgrs.SetActive(false);
			utm.SetActive(false);
		}
		else if (sender.options[sender.value].text == "Lat/Lon Min") {
			latLonSec.SetActive(false);
			latLonMin.SetActive(true);
			mgrs.SetActive(false);
			utm.SetActive(false);
		}
		else if (sender.options[sender.value].text == "MGRS") {
			latLonSec.SetActive(false);
			latLonMin.SetActive(false);
			mgrs.SetActive(true);
			utm.SetActive(false);
		}
		else if (sender.options[sender.value].text == "UTM") {
			latLonSec.SetActive(false);
			latLonMin.SetActive(false);
			mgrs.SetActive(false);
			utm.SetActive(true);
		}
	}
	
	public void ddLoiterPatternValueChanged(Dropdown sender) {
		if (sender.options[sender.value].text == "None") {
			lengthInput.interactable = false;
			diameterInput.interactable = false;
			widthInput.interactable = false;
			azimuthInput.interactable = false;
			loiterTimeInput.interactable = false;
			plannedRollLMTInput.interactable = false;
			turnLeft.interactable = false;
			turnRight.interactable = false;
		}
		else if (sender.options[sender.value].text == "Hexagon") {
			lengthInput.interactable = false;
			diameterInput.interactable = true;
			widthInput.interactable = false;
			azimuthInput.interactable = true;
			loiterTimeInput.interactable = true;
			plannedRollLMTInput.interactable = false;
			turnLeft.interactable = true;
			turnRight.interactable = true;
		}
		else if (sender.options[sender.value].text == "Circular") {
			lengthInput.interactable = false;
			diameterInput.interactable = true;
			widthInput.interactable = false;
			azimuthInput.interactable = true;
			loiterTimeInput.interactable = true;
			plannedRollLMTInput.interactable = true;
			turnLeft.interactable = true;
			turnRight.interactable = true;
		}
		else if (sender.options[sender.value].text == "Figure-8") {
			lengthInput.interactable = true;
			diameterInput.interactable = false;
			widthInput.interactable = true;
			azimuthInput.interactable = true;
			loiterTimeInput.interactable = true;
			plannedRollLMTInput.interactable = false;
			turnLeft.interactable = true;
			turnRight.interactable = true;
		}
	}
	
	void Update() {
		if (lostLinkOK.GetComponent<Image>().color == onColor) {
			lostLinkOn = true;
		}
		else {
			lostLinkOn = false;
		}
		if (flyOverWP.GetComponent<Image>().color == onColor) {
			flyOverOn = true;
		}
		else {
			flyOverOn = false;
		}
		if (losTxOneInhibit.GetComponent<Image>().color == onColor) {
			losTxOneOn = true;
		}
		else {
			losTxOneOn = false;
		}
		if (losTxTwoInhibit.GetComponent<Image>().color == onColor) {
			losTxTwoOn = true;
		}
		else {
			losTxTwoOn = false;
		}
		if (modeOneEnabled.GetComponent<Image>().color == onColor) {
			modeOneOn = true;
		}
		else {
			modeOneOn = false;
		}
		if (modeTwoEnabled.GetComponent<Image>().color == onColor) {
			modeTwoOn = true;
		}
		else {
			modeTwoOn = false;
		}
		if (modeThreeACEnabled.GetComponent<Image>().color == onColor) {
			modeThreeOn = true;
		}
		else {
			modeThreeOn = false;
		}
		if (modeFourEnabled.GetComponent<Image>().color == onColor) {
			modeFourOn = true;
		}
		else {
			modeFourOn = false;
		}
	}
	
	public void leftClick() {
		if (waypointNumber.text == "003") {
			waypointNumber.text = "002";
			goRight.interactable = true;
		}
		else if (waypointNumber.text == "002") {
			waypointNumber.text = "001";
			goLeft.interactable = false;
		}
	}
	
	public void rightClick() {
		if (waypointNumber.text == "001") {
			waypointNumber.text = "002";
			goLeft.interactable = true;
		}
		else if (waypointNumber.text == "002") {
			waypointNumber.text = "003";
			goRight.interactable = false;
		}
	}
	
	public void turnLeftChosen() {
		turnLeft.GetComponent<Image>().color = onColor;
		turnRight.GetComponent<Image>().color = offColor;
	}
	
	public void turnRightChosen() {
		turnLeft.GetComponent<Image>().color = offColor;
		turnRight.GetComponent<Image>().color = onColor;
	}
	
	public void enableDisableLostLinkOK() {
		if (lostLinkOn == true) {
			lostLinkOK.GetComponent<Image>().color = offColor;
		}
		else {
			lostLinkOK.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableFlyOverWP() {
		if (flyOverOn == true) {
			flyOverWP.GetComponent<Image>().color = offColor;
		}
		else {
			flyOverWP.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableLOSTxOne() {
		if (losTxOneOn == true) {
			losTxOneInhibit.GetComponent<Image>().color = offColor;
		}
		else {
			losTxOneInhibit.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableLOSTxTwo() {
		if (losTxTwoOn == true) {
			losTxTwoInhibit.GetComponent<Image>().color = offColor;
		}
		else {
			losTxTwoInhibit.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableModeOne() {
		if (modeOneOn == true) {
			modeOneEnabled.GetComponent<Image>().color = offColor;
		}
		else {
			modeOneEnabled.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableModeTwo() {
		if (modeTwoOn == true) {
			modeTwoEnabled.GetComponent<Image>().color = offColor;
		}
		else {
			modeTwoEnabled.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableModeThree() {
		if (modeThreeOn == true) {
			modeThreeACEnabled.GetComponent<Image>().color = offColor;
		}
		else {
			modeThreeACEnabled.GetComponent<Image>().color = onColor;
		}
	}
	
	public void enableDisableModeFour() {
		if (modeFourOn == true) {
			modeFourEnabled.GetComponent<Image>().color = offColor;
		}
		else {
			modeFourEnabled.GetComponent<Image>().color = onColor;
		}
	}
	
	public void changeCodeText() {
		if (modeFourCode.GetComponentInChildren<Text>().text == "Code A") {
			modeFourCode.GetComponentInChildren<Text>().text = "Code B";
		}
		else if (modeFourCode.GetComponentInChildren<Text>().text == "Code B") {
			modeFourCode.GetComponentInChildren<Text>().text = "Code A";
		}
	}
}
