using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARC210Control : MonoBehaviour
{
	public Button radioOne;
	public Button radioTwo;
	public Dropdown ddOperationalMode;
	public InputField frequency;
	public Button clear;
	public Button secure;
	public InputField cryptoKey;
	public InputField channel;
	public Button antennaSelect;
	public Button squelch;
	public Button amFm;
	public Button guardReceiver;
	public Button receiverSensitivity;
	public Button sqTone;
	public Button lowPower;
	Color32 onColor = new Color32(0, 0, 0, 255);
	Color32 offColor = new Color32(255, 255, 255, 255);
    // Start is called before the first frame update
    private void Start()
    {
        ddOperationalMode.onValueChanged.AddListener(delegate {
			ddOperationalModeValueChanged(ddOperationalMode);
		});
		frequency.GetComponent<InputField>().interactable = false;
		cryptoKey.GetComponent<InputField>().interactable = false;
		channel.GetComponent<InputField>().interactable = false;
    }
	
	public void radioOneClick() {
		radioOne.GetComponent<Image>().color = onColor;
		radioTwo.GetComponent<Image>().color = offColor;
	}
	
	public void radioTwoClick() {
		radioOne.GetComponent<Image>().color = offColor;
		radioTwo.GetComponent<Image>().color = onColor;
	}
	
	public void clearClick() {
		clear.GetComponent<Image>().color = onColor;
		secure.GetComponent<Image>().color = offColor;
	}
	
	public void secureClick() {
		clear.GetComponent<Image>().color = offColor;
		secure.GetComponent<Image>().color = onColor;
	}
	
	public void ddOperationalModeValueChanged(Dropdown sender) {
		if (sender.options[sender.value].text == "Manual") {
			frequency.GetComponent<InputField>().interactable = true;
			cryptoKey.GetComponent<InputField>().interactable = false;
			channel.GetComponent<InputField>().interactable = true;
		}
		else {
			frequency.GetComponent<InputField>().interactable = false;
			cryptoKey.GetComponent<InputField>().interactable = false;
			channel.GetComponent<InputField>().interactable = false;
		}
	}
	
	public void antennaSelectClick() {
		if (antennaSelect.GetComponentInChildren<Text>().text == "Upper") {
			antennaSelect.GetComponentInChildren<Text>().text = "Lower";
		}
		else {
			antennaSelect.GetComponentInChildren<Text>().text = "Upper";
		}
	}
	
	public void squelchClick() {
		if (squelch.GetComponentInChildren<Text>().text == "Enabled") {
			squelch.GetComponentInChildren<Text>().text = "Disabled";
		}
		else {
			squelch.GetComponentInChildren<Text>().text = "Enabled";
		}
	}
	
	public void amFmClick() {
		if (amFm.GetComponentInChildren<Text>().text == "AM") {
			amFm.GetComponentInChildren<Text>().text = "FM";
		}
		else {
			amFm.GetComponentInChildren<Text>().text = "AM";
		}
	}
	
	public void guardReceiverClick() {
		if (guardReceiver.GetComponentInChildren<Text>().text == "Enabled") {
			guardReceiver.GetComponentInChildren<Text>().text = "Disabled";
		}
		else {
			guardReceiver.GetComponentInChildren<Text>().text = "Enabled";
		}
	}
	
	public void receiverSensitivityClick() {
		if (receiverSensitivity.GetComponentInChildren<Text>().text == "Low") {
			receiverSensitivity.GetComponentInChildren<Text>().text = "High";
		}
		else {
			receiverSensitivity.GetComponentInChildren<Text>().text = "Low";
		}
	}
	
	public void sqToneClick() {
		if (sqTone.GetComponentInChildren<Text>().text == "Enabled") {
			sqTone.GetComponentInChildren<Text>().text = "Disabled";
		}
		else {
			sqTone.GetComponentInChildren<Text>().text = "Enabled";
		}
	}
	
	public void lowPowerClick() {
		if (lowPower.GetComponentInChildren<Text>().text == "Enabled") {
			lowPower.GetComponentInChildren<Text>().text = "Disabled";
		}
		else {
			lowPower.GetComponentInChildren<Text>().text = "Enabled";
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
