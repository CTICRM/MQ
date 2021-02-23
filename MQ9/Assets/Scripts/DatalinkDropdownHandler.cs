using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatalinkDropdownHandler : MonoBehaviour
{
	public Dropdown ddAVTx1Antenna;
	public Dropdown ddAVTx2Antenna;
	public Dropdown gdtTrackingSelect;
	public InputField avTailNoInput;
	public InputField avTxOneAntennaInput;
	public InputField avTxTwoAntennaInput;
	public InputField avTxOneInput;
	public InputField avTxTwoInput;
	public InputField gdtTrackingSelectAzimuthInput;
	public InputField gdtTxOneInput;
	public InputField gdtTxTwoInput;
	public InputField gdtAzimuthOffsetInput;
	public InputField elevTrackOffsetInput;
	public Button avTxOneAntennaDown;
	public Button avTxTwoAntennaDown;
	public Button avTxPowerCtrl;
	public Button avTxOne;
	public Button avTxTwo;
	public Button gdtTrackingSelectDown;
	public Button gdtRxSelect;
	public Button gdtTxPowerCtrl;
	public Button gdtTxOne;
	public Button gdtTxTwo;
	public Button gdtAzOffsetDown;
	public Button elevTrackOffsetOnOff;
	public Button elevTrackOffsetDown;
	public GameObject datalinkConfiguration;
	public GameObject AVTx1Antenna_Dir_Man_Az;
	public GameObject AVTx1Antenna_Dir_Man_LL;
	public GameObject AVTx2Antenna_Dir_Man_Az;
	public GameObject AVTx2Antenna_Dir_Man_LL;
	public GameObject gdtAzimuth;
	static int avTxOneAntennaAzimuthValue = 0;
	static int avTxTwoAntennaAzimuthValue = 0;
	static int gdtTrackingSelectAzimuthValue = 0;
	static int gdtAzimuthOffsetValue = 0;
	static float elevTrackOffsetValue = 0.1f;
	Color32 buttonOn = new Color32(0, 255, 0, 255);
	Color32 buttonOff = new Color32(207, 207, 207, 255);
    // Start is called before the first frame update
    void Start()
    {
		avTailNoInput.text = "00027";
		avTxOneAntennaInput.text = avTxOneAntennaAzimuthValue.ToString();
		avTxTwoAntennaInput.text = avTxTwoAntennaAzimuthValue.ToString();
		avTxOneInput.text = "5315";
		avTxTwoInput.text = "5455";
		gdtTrackingSelectAzimuthInput.text = gdtTrackingSelectAzimuthValue.ToString();
		gdtTxOneInput.text = "5710";
		gdtTxTwoInput.text = "5790";
		gdtAzimuthOffsetInput.text = gdtAzimuthOffsetValue.ToString();
		elevTrackOffsetInput.text = elevTrackOffsetValue.ToString();
		
		ddAVTx1Antenna.onValueChanged.AddListener(delegate {
			ddAVTx1AntennaValueChanged(ddAVTx1Antenna);
		});
		
		ddAVTx2Antenna.onValueChanged.AddListener(delegate {
			ddAVTx2AntennaValueChanged(ddAVTx2Antenna);
		});
		
		gdtTrackingSelect.onValueChanged.AddListener(delegate {
			gdtTrackingSelectValueChanged(gdtTrackingSelect);
		});
	}
	
	public void ddAVTx1AntennaValueChanged(Dropdown sender) {
		if (sender.options[sender.value].text == "Dir-Man-Az") {
			AVTx1Antenna_Dir_Man_Az.SetActive(true);
			AVTx1Antenna_Dir_Man_LL.SetActive(false);
		}
		else if (sender.options[sender.value].text == "Dir-Man-LL") {
			AVTx1Antenna_Dir_Man_Az.SetActive(false);
			AVTx1Antenna_Dir_Man_LL.SetActive(true);
		}
		else {
			AVTx1Antenna_Dir_Man_Az.SetActive(false);
			AVTx1Antenna_Dir_Man_LL.SetActive(false);
		}
	}
	
	public void ddAVTx2AntennaValueChanged(Dropdown sender) {
		if (sender.options[sender.value].text == "Dir-Man-Az") {
			AVTx2Antenna_Dir_Man_Az.SetActive(true);
			AVTx2Antenna_Dir_Man_LL.SetActive(false);
		}
		else if (sender.options[sender.value].text == "Dir-Man-LL") {
			AVTx2Antenna_Dir_Man_Az.SetActive(false);
			AVTx2Antenna_Dir_Man_LL.SetActive(true);
		}
		else {
			AVTx2Antenna_Dir_Man_Az.SetActive(false);
			AVTx2Antenna_Dir_Man_LL.SetActive(false);
		}
	}
	
	public void gdtTrackingSelectValueChanged(Dropdown sender) {
		if (sender.options[sender.value].text == "Azimuth") {
			gdtAzimuth.SetActive(true);
		}
		else {
			gdtAzimuth.SetActive(false);
		}
	}
	
	public void avTxPowerCtrlChange() {
		if (avTxPowerCtrl.GetComponent<Button>().GetComponentInChildren<Text>().text == "HI") {
			avTxPowerCtrl.GetComponent<Button>().GetComponentInChildren<Text>().text = "LOW";
		}
		else {
			avTxPowerCtrl.GetComponent<Button>().GetComponentInChildren<Text>().text = "HI";
		}
	}
	
	public void avTxOneChange() {
		if (avTxOne.GetComponent<Button>().GetComponentInChildren<Text>().text == "OFF") {
			avTxOne.GetComponent<Button>().GetComponentInChildren<Text>().text = "ON";
			avTxOne.GetComponent<Image>().color = buttonOn;
		}
		else {
			avTxOne.GetComponent<Button>().GetComponentInChildren<Text>().text = "OFF";
			avTxOne.GetComponent<Image>().color = buttonOff;
		}
	}
	
	public void avTxTwoChange() {
		if (avTxTwo.GetComponent<Button>().GetComponentInChildren<Text>().text == "OFF") {
			avTxTwo.GetComponent<Button>().GetComponentInChildren<Text>().text = "ON";
			avTxTwo.GetComponent<Image>().color = buttonOn;
		}
		else {
			avTxTwo.GetComponent<Button>().GetComponentInChildren<Text>().text = "OFF";
			avTxTwo.GetComponent<Image>().color = buttonOff;
		}
	}
	
	public void gdtRxSelectChange() {
		if (gdtRxSelect.GetComponent<Button>().GetComponentInChildren<Text>().text == "Rx1") {
			gdtRxSelect.GetComponent<Button>().GetComponentInChildren<Text>().text = "Rx2";
		}
		else {
			gdtRxSelect.GetComponent<Button>().GetComponentInChildren<Text>().text = "Rx1";
		}
	}
	
	public void gdtTxPowerCtrlChange() {
		if (gdtTxPowerCtrl.GetComponent<Button>().GetComponentInChildren<Text>().text == "HI") {
			gdtTxPowerCtrl.GetComponent<Button>().GetComponentInChildren<Text>().text = "LOW";
		}
		else {
			gdtTxPowerCtrl.GetComponent<Button>().GetComponentInChildren<Text>().text = "HI";
		}
	}
	
	public void gdtTxOneChange() {
		if (gdtTxOne.GetComponent<Button>().GetComponentInChildren<Text>().text == "OFF") {
			gdtTxOne.GetComponent<Button>().GetComponentInChildren<Text>().text = "ON";
			gdtTxOne.GetComponent<Image>().color = buttonOn;
		}
		else {
			gdtTxOne.GetComponent<Button>().GetComponentInChildren<Text>().text = "OFF";
			gdtTxOne.GetComponent<Image>().color = buttonOff;
		}
	}
	
	public void gdtTxTwoChange() {
		if (gdtTxTwo.GetComponent<Button>().GetComponentInChildren<Text>().text == "OFF") {
			gdtTxTwo.GetComponent<Button>().GetComponentInChildren<Text>().text = "ON";
			gdtTxTwo.GetComponent<Image>().color = buttonOn;
		}
		else {
			gdtTxTwo.GetComponent<Button>().GetComponentInChildren<Text>().text = "OFF";
			gdtTxTwo.GetComponent<Image>().color = buttonOff;
		}
	}
	
	public void elevTrackOffsetChange() {
		if (elevTrackOffsetOnOff.GetComponent<Button>().GetComponentInChildren<Text>().text == "OFF") {
			elevTrackOffsetOnOff.GetComponent<Button>().GetComponentInChildren<Text>().text = "ON";
		}
		else {
			elevTrackOffsetOnOff.GetComponent<Button>().GetComponentInChildren<Text>().text = "OFF";
		}
	}
	
	public void avTxOneAntennaAzimuthIncrement() {
		avTxOneAntennaAzimuthValue += 1;
		avTxOneAntennaDown.interactable = true;
		avTxOneAntennaInput.text = avTxOneAntennaAzimuthValue.ToString();
	}
	
	public void avTxOneAntennaAzimuthDecrement() {
		avTxOneAntennaAzimuthValue -= 1;
		if (avTxOneAntennaAzimuthValue <= 0) {
			avTxOneAntennaDown.interactable = false;
		}
		avTxOneAntennaInput.text = avTxOneAntennaAzimuthValue.ToString();
	}
	
	public void avTxTwoAntennaAzimuthIncrement() {
		avTxTwoAntennaAzimuthValue += 1;
		avTxTwoAntennaDown.interactable = true;
		avTxTwoAntennaInput.text = avTxTwoAntennaAzimuthValue.ToString();
	}
	
	public void avTxTwoAntennaAzimuthDecrement() {
		avTxTwoAntennaAzimuthValue -= 1;
		if (avTxTwoAntennaAzimuthValue <= 0) {
			avTxTwoAntennaDown.interactable = false;
		}
		avTxTwoAntennaInput.text = avTxTwoAntennaAzimuthValue.ToString();
	}
	
	public void gdtTrackingSelectAzimuthIncrement() {
		gdtTrackingSelectAzimuthValue += 1;
		gdtTrackingSelectDown.interactable = true;
		gdtTrackingSelectAzimuthInput.text = gdtTrackingSelectAzimuthValue.ToString();
	}
	
	public void gdtTrackingSelectAzimuthDecrement() {
		gdtTrackingSelectAzimuthValue -= 1;
		if (gdtTrackingSelectAzimuthValue <= 0) {
			gdtTrackingSelectDown.interactable = false;
		}
		gdtTrackingSelectAzimuthInput.text = gdtTrackingSelectAzimuthValue.ToString();
	}
	
	public void gdtAzimuthOffsetIncrement() {
		gdtAzimuthOffsetValue += 1;
		gdtAzOffsetDown.interactable = true;
		gdtAzimuthOffsetInput.text = gdtAzimuthOffsetValue.ToString();
	}
	
	public void gdtAzimuthOffsetDecrement() {
		gdtAzimuthOffsetValue -= 1;
		if (gdtAzimuthOffsetValue <= 0) {
			gdtAzOffsetDown.interactable = false;
		}
		gdtAzimuthOffsetInput.text = gdtAzimuthOffsetValue.ToString();
	}
	
	public void elevTrackOffsetIncrement() {
		elevTrackOffsetValue += 0.1f;
		elevTrackOffsetDown.interactable = true;
		elevTrackOffsetInput.text = elevTrackOffsetValue.ToString();
	}
	
	public void elevTrackOffsetDecrement() {
		elevTrackOffsetValue -= 0.1f;
		if (elevTrackOffsetValue <= 0.0f) {
			elevTrackOffsetDown.interactable = false;
		}
		elevTrackOffsetInput.text = elevTrackOffsetValue.ToString();
	}
}
