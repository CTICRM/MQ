using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Houses the functions for Satellite B found in the Ku SATCOM
// Configuration popup

public class SatelliteB : MonoBehaviour
{
    public InputField satBCLFrequency;
	public InputField satBRLFrequency;
	public Button satBSpread;
	public Button satBPolar;
	public InputField satBPNCode;
    public Button satBTwoLineNORAD;
	public Button satBIntelSAT;
	public InputField satBSATInput;
	/* public Button currJanB;
	public Button currFebB;
	public Button currMarB;
	public Button currAprB;
	public Button currMayB;
	public Button currJunB;
	public Button currJulB;
	public Button currAugB;
	public Button currSepB;
	public Button currOctB;
	public Button currNovB;
	public Button currDecB;
	public InputField currDayB;
	public InputField currYearB;
	public InputField currHourB;
	public InputField currMinB;
	public InputField currSecB;
	public Button epochJanB;
	public Button epochFebB;
	public Button epochMarB;
	public Button epochAprB;
	public Button epochMayB;
	public Button epochJunB;
	public Button epochJulB;
	public Button epochAugB;
	public Button epochSepB;
	public Button epochOctB;
	public Button epochNovB;
	public Button epochDecB;
	public InputField epochDayB;
	public InputField epochYearB;
	public InputField epochHourB;
	public InputField epochMinB;
	public InputField epochSecB; */
	public InputField satBLONC;
	public InputField satBLATC;
	public InputField satBLONC1;
	public InputField satBLATC1;
	public InputField satBLONS;
	public InputField satBLATS;
	public InputField satBLONS1;
	public InputField satBLATS1;
	public InputField satB170HourLongitude;
	public InputField satB170HourLatitude;
	public InputField satBLM0;
	public InputField satBLM1;
	public InputField satBLM2;
	public InputField satBNORADTwoLineElementEphemerisData1;
	public InputField satBNORADTwoLineElementEphemerisData2;
	static float satBCLFrequencyValue = 12000.250f;
	static float satBRLFrequencyValue = 14000.250f;
	static int satBPNCodeValue = 0;
	Color32 onBlack = new Color32(0, 0, 0, 255); // The button is selected
	Color32 offWhite = new Color32(255, 255, 255, 255); // The button is no longer selected
    // Start is called before the first frame update
    void Start()
    {
        satBLONC.text = "0.000000";
		satBLONC1.text = "0.000000";
		satBLONS.text = "0.000000";
		satBLONS1.text = "0.000000";
		satBLATC.text = "0.000000";
		satBLATC1.text = "0.000000";
		satBLATS.text = "0.000000";
		satBLATS1.text = "0.000000";
		satB170HourLongitude.text = "0.000000";
		satB170HourLatitude.text = "0.000000";
		satBLM0.text = "0.000000";
		satBLM1.text = "0.000000";
		satBLM2.text = "0.000000";
		satBCLFrequency.text = satBCLFrequencyValue.ToString();
		satBRLFrequency.text = satBRLFrequencyValue.ToString();
		satBPNCode.text = satBPNCodeValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
		
	public void satBTwoLineNORADClick() {
		satBTwoLineNORAD.GetComponent<Image>().color = onBlack;
		satBIntelSAT.GetComponent<Image>().color = offWhite;
	}
	
	public void satBIntelSATClick() {
		satBTwoLineNORAD.GetComponent<Image>().color = offWhite;
		satBIntelSAT.GetComponent<Image>().color = onBlack;
	}
	
	public void satBCLFrequencyIncrement() {
		satBCLFrequencyValue += 0.001f;
		satBCLFrequency.text = satBCLFrequencyValue.ToString();
	}
	
	public void satBCLFrequencyDecrement() {
		satBCLFrequencyValue -= 0.001f;
		if (satBCLFrequencyValue <= 0) {
			satBCLFrequencyValue = 0;
		}
		satBCLFrequency.text = satBCLFrequencyValue.ToString();
	}
	
	public void satBRLFrequencyIncrement() {
		satBRLFrequencyValue += 0.001f;
		satBRLFrequency.text = satBRLFrequencyValue.ToString();
	}
	
	public void satBRLFrequencyDecrement() {
		satBRLFrequencyValue -= 0.001f;
		if (satBRLFrequencyValue <= 0) {
			satBRLFrequencyValue = 0;
		}
		satBRLFrequency.text = satBRLFrequencyValue.ToString();
	}
	
	public void satBSpreadClick() {
		if (satBSpread.GetComponentInChildren<Text>().text == "Disabled") {
			satBSpread.GetComponentInChildren<Text>().text = "Enabled";
		}
		else {
			satBSpread.GetComponentInChildren<Text>().text = "Disabled";
		}
	}
	
	public void satBPolarClick() {
		if (satBPolar.GetComponentInChildren<Text>().text == "Vertical") {
			satBPolar.GetComponentInChildren<Text>().text = "Horizontal";
		}
		else {
			satBPolar.GetComponentInChildren<Text>().text = "Vertical";
		}
	}
	
	public void satBPNCodeIncrement() {
		satBPNCodeValue++;
		satBPNCode.text = satBPNCodeValue.ToString();
	}
	
	public void satBPNCodeDecrement() {
		satBPNCodeValue--;
		if (satBPNCodeValue <= 0) {
			satBPNCodeValue = 0;
		}
		satBPNCode.text = satBPNCodeValue.ToString();
	}
}
