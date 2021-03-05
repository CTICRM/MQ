using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KuSATCOMConfiguration : MonoBehaviour
{
	public Button airborneModemOnOff;
	public GameObject turnAirborneModemOff;
	public GameObject turnAirborneModemOn;
	public Button clData;
	public Button rlTx;
	public InputField rlAttenuation;
	public Button apply;
	public Button auto;
	public Button stow;
	public InputField azimuthStowAngle;
	public InputField elevationStowAngle;
	public InputField polarizationStowAngle;
	public Button encrypt;
	public Button bypass;
	public Button clAlgorithm1;
	public Button clAlgorithm2;
	public Button rlAlgorithm1;
	public Button rlAlgorithm2;
	public Button channelized;
	public Button networked;
	public Button rlModeInternal;
	public Button rlModeExternal;
	public Button rlModeShared;
	public Button channel1MPEG2;
	public Button channel1VQ;
	public Button channel1Track;
	public Button channel1Dwell;
	public Button channel1Custom;
	public Button channel2MPEG2;
	public Button channel2VQ;
	public Button channel2Uncompressed;
	public Button channel2Spotlight;
	public Button channel2Search;
	public Button channel2Pilot;
	public InputField gop;
	public Button audioOn;
	public Button audioOff;
	public InputField brightness;
	public Button decimateOn;
	public Button decimateOff;
	public InputField saturation;
	public Button variableFrameRateOn;
	public Button variableFrameRateOff;
	public InputField contrast;
	public Button iFrameOnlyOn;
	public Button iFrameOnlyOff;
	public InputField qualityLimit;
	public Button qualityPreferenceOn;
	public Button qualityPreferenceOff;
	public InputField desiredQuality;
	public InputField bitRate;
	static int rlAttenuationValue = 0;
	static int gopValue = 32;
	static int brightnessValue = 50;
	static int saturationValue = 50;
	static int contrastValue = 50;
	static int qualityLimitValue = 2;
	static int desiredQualityValue = 2;
	static int bitRateValue = 3000000;
	Color32 onBlack = new Color32(0, 0, 0, 255);
	Color32 offWhite = new Color32(255, 255, 255, 255);
	bool applyClicked = true;
    // Start is called before the first frame update
    void Start()
    {
		rlAttenuation.text = rlAttenuationValue.ToString();
		azimuthStowAngle.text = "0.000";
		elevationStowAngle.text = "0.000";
		polarizationStowAngle.text = "0.000";
		gop.text = gopValue.ToString();
		brightness.text = brightnessValue.ToString();
		saturation.text = saturationValue.ToString();
		contrast.text = contrastValue.ToString();
		qualityLimit.text = qualityLimitValue.ToString();
		desiredQuality.text = desiredQualityValue.ToString();
		bitRate.text = bitRateValue.ToString();
		Button btn = apply.GetComponent<Button>();
		btn.onClick.AddListener(applyClick);
    }

    // Update is called once per frame
    void Update()
    {
        /* if (rlTx.GetComponentInChildren<Text>().text == "Enabled" && applyClicked) {
			rlTx.GetComponentInChildren<Text>().text = "Disabled";
			applyClicked = false;
		}
		else if (rlTx.GetComponentInChildren<Text>().text == "Disabled" && applyClicked) {
			rlTx.GetComponentInChildren<Text>().text = "Enabled";
			applyClicked = false;
		} */
    }
	
	public void airborneModemClick() {
		if (airborneModemOnOff.GetComponentInChildren<Text>().text == "On") {
			turnAirborneModemOff.SetActive(true);
		}
		else {
			turnAirborneModemOn.SetActive(true);
		}
	}
	
	public void clDataClick() {
		if (clData.GetComponentInChildren<Text>().text == "Enabled" && applyClicked == true) {
			clData.GetComponentInChildren<Text>().text = "Disabled";
			applyClicked = false;
			Debug.Log("CL Data Button is Disabled");
			//Debug.Log(applyClicked);
		}
		else if (clData.GetComponentInChildren<Text>().text == "Disabled" && applyClicked == true) {
			clData.GetComponentInChildren<Text>().text = "Enabled";
			applyClicked = false;
			Debug.Log("CL Data Button is Enabled");
			//Debug.Log(applyClicked);
		}
	}
	
	public void rlTxClick() {
		if (rlTx.GetComponentInChildren<Text>().text == "Enabled" && applyClicked == true) {
			rlTx.GetComponentInChildren<Text>().text = "Disabled";
			applyClicked = false;
			Debug.Log("RL TX Button is Disabled");
			//Debug.Log(applyClicked);
		}
		else if (rlTx.GetComponentInChildren<Text>().text == "Disabled" && applyClicked == true) {
			rlTx.GetComponentInChildren<Text>().text = "Enabled";
			applyClicked = false;
			Debug.Log("RL TX Button is Enabled");
			//Debug.Log(applyClicked);
		}
	}
	
	void applyClick() {
		applyClicked = true;
	}
	
	public void rlAttenuationIncrement() {
		rlAttenuationValue++;
		rlAttenuation.text = rlAttenuationValue.ToString();
	}
	
	public void rlAttenuationDecrement() {
		rlAttenuationValue--;
		if (rlAttenuationValue <= 0) {
			rlAttenuationValue = 0;
		}
		rlAttenuation.text = rlAttenuationValue.ToString();
	}
	
	public void autoClick() {
		auto.GetComponent<Image>().color = onBlack;
		stow.GetComponent<Image>().color = offWhite;
	}
	
	public void stowClick() {
		auto.GetComponent<Image>().color = offWhite;
		stow.GetComponent<Image>().color = onBlack;
	}
	
	public void encryptClick() {
		encrypt.GetComponent<Image>().color = onBlack;
		bypass.GetComponent<Image>().color = offWhite;
	}
	
	public void bypassClick() {
		encrypt.GetComponent<Image>().color = offWhite;
		bypass.GetComponent<Image>().color = onBlack;
	}
	
	public void clAlgorithm1Click() {
		clAlgorithm1.GetComponent<Image>().color = onBlack;
		clAlgorithm2.GetComponent<Image>().color = offWhite;
	}
	
	public void clAlgorithm2Click() {
		clAlgorithm1.GetComponent<Image>().color = offWhite;
		clAlgorithm2.GetComponent<Image>().color = onBlack;
	}
	
	public void rlAlgorithm1Click() {
		rlAlgorithm1.GetComponent<Image>().color = onBlack;
		rlAlgorithm2.GetComponent<Image>().color = offWhite;
	}
	
	public void rlAlgorithm2Click() {
		rlAlgorithm1.GetComponent<Image>().color = offWhite;
		rlAlgorithm2.GetComponent<Image>().color = onBlack;
	}
	
	public void channelizedClick() {
		channelized.GetComponent<Image>().color = onBlack;
		networked.GetComponent<Image>().color = offWhite;
	}
	
	public void networkedClick() {
		channelized.GetComponent<Image>().color = offWhite;
		networked.GetComponent<Image>().color = onBlack;
	}
	
	public void internalClick() {
		rlModeInternal.GetComponent<Image>().color = onBlack;
		rlModeExternal.GetComponent<Image>().color = offWhite;
		rlModeShared.GetComponent<Image>().color = offWhite;
	}
	
	public void externalClick() {
		rlModeInternal.GetComponent<Image>().color = offWhite;
		rlModeExternal.GetComponent<Image>().color = onBlack;
		rlModeShared.GetComponent<Image>().color = offWhite;
	}
	
	public void sharedClick() {
		rlModeInternal.GetComponent<Image>().color = offWhite;
		rlModeExternal.GetComponent<Image>().color = offWhite;
		rlModeShared.GetComponent<Image>().color = onBlack;
	}
	
	public void channel1MPEG2Click() {
		channel1MPEG2.GetComponent<Image>().color = onBlack;
		channel1VQ.GetComponent<Image>().color = offWhite;
	}
	
	public void channel1VQClick() {
		channel1MPEG2.GetComponent<Image>().color = offWhite;
		channel1VQ.GetComponent<Image>().color = onBlack;
	}
	
	public void channel1TrackClick() {
		channel1Track.GetComponent<Image>().color = onBlack;
		channel1Dwell.GetComponent<Image>().color = offWhite;
		channel1Custom.GetComponent<Image>().color = offWhite;
	}
	
	public void channel1DwellClick() {
		channel1Track.GetComponent<Image>().color = offWhite;
		channel1Dwell.GetComponent<Image>().color = onBlack;
		channel1Custom.GetComponent<Image>().color = offWhite;
	}
	
	public void channel1CustomClick() {
		channel1Track.GetComponent<Image>().color = offWhite;
		channel1Dwell.GetComponent<Image>().color = offWhite;
		channel1Custom.GetComponent<Image>().color = onBlack;
	}
	
	public void channel2MPEG2Click() {
		channel2MPEG2.GetComponent<Image>().color = onBlack;
		channel2VQ.GetComponent<Image>().color = offWhite;
	}
	
	public void channel2VQClick() {
		channel2MPEG2.GetComponent<Image>().color = offWhite;
		channel2VQ.GetComponent<Image>().color = onBlack;
	}
	
	public void channel2UncompressedClick() {
		channel2Uncompressed.GetComponent<Image>().color = onBlack;
		channel2Spotlight.GetComponent<Image>().color = offWhite;
		channel2Search.GetComponent<Image>().color = offWhite;
		channel2Pilot.GetComponent<Image>().color = offWhite;
	}
	
	public void channel2SpotlightClick() {
		channel2Uncompressed.GetComponent<Image>().color = offWhite;
		channel2Spotlight.GetComponent<Image>().color = onBlack;
		channel2Search.GetComponent<Image>().color = offWhite;
		channel2Pilot.GetComponent<Image>().color = offWhite;
	}
	
	public void channel2SearchClick() {
		channel2Uncompressed.GetComponent<Image>().color = offWhite;
		channel2Spotlight.GetComponent<Image>().color = offWhite;
		channel2Search.GetComponent<Image>().color = onBlack;
		channel2Pilot.GetComponent<Image>().color = offWhite;
	}
	
	public void channel2PilotClick() {
		channel2Uncompressed.GetComponent<Image>().color = offWhite;
		channel2Spotlight.GetComponent<Image>().color = offWhite;
		channel2Search.GetComponent<Image>().color = offWhite;
		channel2Pilot.GetComponent<Image>().color = onBlack;
	}
	
	public void gopIncrement() {
		gopValue++;
		gop.text = gopValue.ToString();
	}
	
	public void gopDecrement() {
		gopValue--;
		if (gopValue <= 0) {
			gopValue = 0;
		}
		gop.text = gopValue.ToString();
	}
	
	public void audioOnClick() {
		audioOn.GetComponent<Image>().color = onBlack;
		audioOff.GetComponent<Image>().color = offWhite;
	}
	
	public void audioOffClick() {
		audioOn.GetComponent<Image>().color = offWhite;
		audioOff.GetComponent<Image>().color = onBlack;
	}
	
	public void brightnessIncrement() {
		brightnessValue++;
		brightness.text = brightnessValue.ToString();
	}
	
	public void brightnessDecrement() {
		brightnessValue--;
		if (brightnessValue <= 0) {
			brightnessValue = 0;
		}
		brightness.text = brightnessValue.ToString();
	}
	
	public void decimateOnClick() {
		decimateOn.GetComponent<Image>().color = onBlack;
		decimateOff.GetComponent<Image>().color = offWhite;
	}
	
	public void decimateOffClick() {
		decimateOn.GetComponent<Image>().color = offWhite;
		decimateOff.GetComponent<Image>().color = onBlack;
	}
	
	public void saturationIncrement() {
		saturationValue++;
		saturation.text = saturationValue.ToString();
	}
	
	public void saturationDecrement() {
		saturationValue--;
		if (saturationValue <= 0) {
			saturationValue = 0;
		}
		saturation.text = saturationValue.ToString();
	}
	
	public void variableFrameRateOnClick() {
		variableFrameRateOn.GetComponent<Image>().color = onBlack;
		variableFrameRateOff.GetComponent<Image>().color = offWhite;
	}
	
	public void variableFrameRateOffClick() {
		variableFrameRateOn.GetComponent<Image>().color = offWhite;
		variableFrameRateOff.GetComponent<Image>().color = onBlack;
	}
	
	public void contrastIncrement() {
		contrastValue++;
		contrast.text = contrastValue.ToString();
	}
	
	public void contrastDecrement() {
		contrastValue--;
		if (contrastValue <= 0) {
			contrastValue = 0;
		}
		contrast.text = contrastValue.ToString();
	}
	
	public void iFrameOnlyOnClick() {
		iFrameOnlyOn.GetComponent<Image>().color = onBlack;
		iFrameOnlyOff.GetComponent<Image>().color = offWhite;
	}
	
	public void iFrameOnlyOffClick() {
		iFrameOnlyOn.GetComponent<Image>().color = offWhite;
		iFrameOnlyOff.GetComponent<Image>().color = onBlack;
	}
	
	public void qualityLimitIncrement() {
		qualityLimitValue++;
		qualityLimit.text = qualityLimitValue.ToString();
	}
	
	public void qualityLimitDecrement() {
		qualityLimitValue--;
		if (qualityLimitValue <= 0) {
			qualityLimitValue = 0;
		}
		qualityLimit.text = qualityLimitValue.ToString();
	}
	
	public void qualityPreferenceOnClick() {
		qualityPreferenceOn.GetComponent<Image>().color = onBlack;
		qualityPreferenceOff.GetComponent<Image>().color = offWhite;
	}
	
	public void qualityPreferenceOffClick() {
		qualityPreferenceOn.GetComponent<Image>().color = offWhite;
		qualityPreferenceOff.GetComponent<Image>().color = onBlack;
	}
	
	public void desiredQualityIncrement() {
		desiredQualityValue++;
		desiredQuality.text = desiredQualityValue.ToString();
	}
	
	public void desiredQualityDecrement() {
		desiredQualityValue--;
		if (desiredQualityValue <= 0) {
			desiredQualityValue = 0;
		}
		desiredQuality.text = desiredQualityValue.ToString();
	}
	
	public void bitRateIncrement() {
		bitRateValue++;
		bitRate.text = bitRateValue.ToString();
	}
	
	public void bitRateDecrement() {
		bitRateValue--;
		if (bitRateValue <= 0) {
			bitRateValue = 0;
		}
		bitRate.text = bitRateValue.ToString();
	}
}
