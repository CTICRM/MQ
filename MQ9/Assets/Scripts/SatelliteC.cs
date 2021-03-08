using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Houses the functions for Satellite C found in the Ku SATCOM
// Configuration popup

public class SatelliteC : MonoBehaviour
{
    public InputField satCCLFrequency;
	public InputField satCRLFrequency;
	public Button satCSpread;
	public Button satCPolar;
	public InputField satCPNCode;
    public Button satCTwoLineNORAD;
	public Button satCIntelSAT;
	public InputField satCSATInput;
	/* public Button currJanC;
	public Button currFebC;
	public Button currMarC;
	public Button currAprC;
	public Button currMayC;
	public Button currJunC;
	public Button currJulC;
	public Button currAugC;
	public Button currSepC;
	public Button currOctC;
	public Button currNovC;
	public Button currDecC;
	public InputField currDayC;
	public InputField currYearC;
	public InputField currHourC;
	public InputField currMinC;
	public InputField currSecC;
	public Button epochJanC;
	public Button epochFebC;
	public Button epochMarC;
	public Button epochAprC;
	public Button epochMayC;
	public Button epochJunC;
	public Button epochJulC;
	public Button epochAugC;
	public Button epochSepC;
	public Button epochOctC;
	public Button epochNovC;
	public Button epochDecC;
	public InputField epochDayC;
	public InputField epochYearC;
	public InputField epochHourC;
	public InputField epochMinC;
	public InputField epochSecC; */
	public InputField satCLONC;
	public InputField satCLATC;
	public InputField satCLONC1;
	public InputField satCLATC1;
	public InputField satCLONS;
	public InputField satCLATS;
	public InputField satCLONS1;
	public InputField satCLATS1;
	public InputField satC170HourLongitude;
	public InputField satC170HourLatitude;
	public InputField satCLM0;
	public InputField satCLM1;
	public InputField satCLM2;
	public InputField satCNORADTwoLineElementEphemerisData1;
	public InputField satCNORADTwoLineElementEphemerisData2;
	static float satCCLFrequencyValue = 12000.250f;
	static float satCRLFrequencyValue = 14000.250f;
	static int satCPNCodeValue = 0;
	Color32 onBlack = new Color32(0, 0, 0, 255); // The button is selected
	Color32 offWhite = new Color32(255, 255, 255, 255); // The button is no longer selected
    // Start is called before the first frame update
    void Start()
    {
        satCLONC.text = "0.000000";
		satCLONC1.text = "0.000000";
		satCLONS.text = "0.000000";
		satCLONS1.text = "0.000000";
		satCLATC.text = "0.000000";
		satCLATC1.text = "0.000000";
		satCLATS.text = "0.000000";
		satCLATS1.text = "0.000000";
		satC170HourLongitude.text = "0.000000";
		satC170HourLatitude.text = "0.000000";
		satCLM0.text = "0.000000";
		satCLM1.text = "0.000000";
		satCLM2.text = "0.000000";
		satCCLFrequency.text = satCCLFrequencyValue.ToString();
		satCRLFrequency.text = satCRLFrequencyValue.ToString();
		satCPNCode.text = satCPNCodeValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
		
	public void satCTwoLineNORADClick() {
		satCTwoLineNORAD.GetComponent<Image>().color = onBlack;
		satCIntelSAT.GetComponent<Image>().color = offWhite;
	}
	
	public void satCIntelSATClick() {
		satCTwoLineNORAD.GetComponent<Image>().color = offWhite;
		satCIntelSAT.GetComponent<Image>().color = onBlack;
	}
	
	public void satCCLFrequencyIncrement() {
		satCCLFrequencyValue += 0.001f;
		satCCLFrequency.text = satCCLFrequencyValue.ToString();
	}
	
	public void satCCLFrequencyDecrement() {
		satCCLFrequencyValue -= 0.001f;
		if (satCCLFrequencyValue <= 0) {
			satCCLFrequencyValue = 0;
		}
		satCCLFrequency.text = satCCLFrequencyValue.ToString();
	}
	
	public void satCRLFrequencyIncrement() {
		satCRLFrequencyValue += 0.001f;
		satCRLFrequency.text = satCRLFrequencyValue.ToString();
	}
	
	public void satCRLFrequencyDecrement() {
		satCRLFrequencyValue -= 0.001f;
		if (satCRLFrequencyValue <= 0) {
			satCRLFrequencyValue = 0;
		}
		satCRLFrequency.text = satCRLFrequencyValue.ToString();
	}
	
	public void satCSpreadClick() {
		if (satCSpread.GetComponentInChildren<Text>().text == "Disabled") {
			satCSpread.GetComponentInChildren<Text>().text = "Enabled";
		}
		else {
			satCSpread.GetComponentInChildren<Text>().text = "Disabled";
		}
	}
	
	public void satCPolarClick() {
		if (satCPolar.GetComponentInChildren<Text>().text == "Vertical") {
			satCPolar.GetComponentInChildren<Text>().text = "Horizontal";
		}
		else {
			satCPolar.GetComponentInChildren<Text>().text = "Vertical";
		}
	}
	
	public void satCPNCodeIncrement() {
		satCPNCodeValue++;
		satCPNCode.text = satCPNCodeValue.ToString();
	}
	
	public void satCPNCodeDecrement() {
		satCPNCodeValue--;
		if (satCPNCodeValue <= 0) {
			satCPNCodeValue = 0;
		}
		satCPNCode.text = satCPNCodeValue.ToString();
	}
}
