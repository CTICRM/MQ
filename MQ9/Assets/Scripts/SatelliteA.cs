using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SatelliteA : MonoBehaviour
{
	public InputField satACLFrequency;
	public InputField satARLFrequency;
	public Button satASpread;
	public Button satAPolar;
	public InputField satAPNCode;
    public Button satATwoLineNORAD;
	public Button satAIntelSAT;
	public InputField satASATInput;
	/* public Button currJanA;
	public Button currFebA;
	public Button currMarA;
	public Button currAprA;
	public Button currMayA;
	public Button currJunA;
	public Button currJulA;
	public Button currAugA;
	public Button currSepA;
	public Button currOctA;
	public Button currNovA;
	public Button currDecA;
	public InputField currDayA;
	public InputField currYearA;
	public InputField currHourA;
	public InputField currMinA;
	public InputField currSecA;
	public Button epochJanA;
	public Button epochFebA;
	public Button epochMarA;
	public Button epochAprA;
	public Button epochMayA;
	public Button epochJunA;
	public Button epochJulA;
	public Button epochAugA;
	public Button epochSepA;
	public Button epochOctA;
	public Button epochNovA;
	public Button epochDecA;
	public InputField epochDayA;
	public InputField epochYearA;
	public InputField epochHourA;
	public InputField epochMinA;
	public InputField epochSecA; */
	public InputField satALONC;
	public InputField satALATC;
	public InputField satALONC1;
	public InputField satALATC1;
	public InputField satALONS;
	public InputField satALATS;
	public InputField satALONS1;
	public InputField satALATS1;
	public InputField satA170HourLongitude;
	public InputField satA170HourLatitude;
	public InputField satALM0;
	public InputField satALM1;
	public InputField satALM2;
	public InputField satANORADTwoLineElementEphemerisData1;
	public InputField satANORADTwoLineElementEphemerisData2;
	static float satACLFrequencyValue = 12000.250f;
	static float satARLFrequencyValue = 14000.250f;
	static int satAPNCodeValue = 0;
	Color32 onBlack = new Color32(0, 0, 0, 255);
	Color32 offWhite = new Color32(255, 255, 255, 255);
    // Start is called before the first frame update
    void Start()
    {
        satALONC.text = "0.000000";
		satALONC1.text = "0.000000";
		satALONS.text = "0.000000";
		satALONS1.text = "0.000000";
		satALATC.text = "0.000000";
		satALATC1.text = "0.000000";
		satALATS.text = "0.000000";
		satALATS1.text = "0.000000";
		satA170HourLongitude.text = "0.000000";
		satA170HourLatitude.text = "0.000000";
		satALM0.text = "0.000000";
		satALM1.text = "0.000000";
		satALM2.text = "0.000000";
		satACLFrequency.text = satACLFrequencyValue.ToString();
		satARLFrequency.text = satARLFrequencyValue.ToString();
		satAPNCode.text = satAPNCodeValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
		
	public void satATwoLineNORADClick() {
		satATwoLineNORAD.GetComponent<Image>().color = onBlack;
		satAIntelSAT.GetComponent<Image>().color = offWhite;
	}
	
	public void satAIntelSATClick() {
		satATwoLineNORAD.GetComponent<Image>().color = offWhite;
		satAIntelSAT.GetComponent<Image>().color = onBlack;
	}
	
	public void satACLFrequencyIncrement() {
		satACLFrequencyValue += 0.001f;
		satACLFrequency.text = satACLFrequencyValue.ToString();
	}
	
	public void satACLFrequencyDecrement() {
		satACLFrequencyValue -= 0.001f;
		if (satACLFrequencyValue <= 0) {
			satACLFrequencyValue = 0;
		}
		satACLFrequency.text = satACLFrequencyValue.ToString();
	}
	
	public void satARLFrequencyIncrement() {
		satARLFrequencyValue += 0.001f;
		satARLFrequency.text = satARLFrequencyValue.ToString();
	}
	
	public void satARLFrequencyDecrement() {
		satARLFrequencyValue -= 0.001f;
		if (satARLFrequencyValue <= 0) {
			satARLFrequencyValue = 0;
		}
		satARLFrequency.text = satARLFrequencyValue.ToString();
	}
	
	public void satASpreadClick() {
		if (satASpread.GetComponentInChildren<Text>().text == "Disabled") {
			satASpread.GetComponentInChildren<Text>().text = "Enabled";
		}
		else {
			satASpread.GetComponentInChildren<Text>().text = "Disabled";
		}
	}
	
	public void satAPolarClick() {
		if (satAPolar.GetComponentInChildren<Text>().text == "Vertical") {
			satAPolar.GetComponentInChildren<Text>().text = "Horizontal";
		}
		else {
			satAPolar.GetComponentInChildren<Text>().text = "Vertical";
		}
	}
	
	public void satAPNCodeIncrement() {
		satAPNCodeValue++;
		satAPNCode.text = satAPNCodeValue.ToString();
	}
	
	public void satAPNCodeDecrement() {
		satAPNCodeValue--;
		if (satAPNCodeValue <= 0) {
			satAPNCodeValue = 0;
		}
		satAPNCode.text = satAPNCodeValue.ToString();
	}
}
