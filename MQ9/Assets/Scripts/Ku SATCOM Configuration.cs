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
    // Start is called before the first frame update
    void Start()
    {
        /* satACLFrequency.GetComponentInChildren<Text>().text = "12000.250";
		satARLFrequency.GetComponentInChildren<Text>().text = "14000.250";
		satAPNCode.GetComponentInChildren<Text>().text = "0";
		satBCLFrequency.GetComponentInChildren<Text>().text = "12000.250";
		satBRLFrequency.GetComponentInChildren<Text>().text = "14000.250";
		satBPNCode.GetComponentInChildren<Text>().text = "0";
		satCCLFrequency.GetComponentInChildren<Text>().text = "12000.250";
		satCRLFrequency.GetComponentInChildren<Text>().text = "14000.250";
		satCPNCode.GetComponentInChildren<Text>().text = "0"; */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void airborneModemOffClick() {
		if (airborneModemOnOff.GetComponentInChildren<Text>().text == "On") {
			turnAirborneModemOff.SetActive(true);
		}
		else {
			turnAirborneModemOn.SetActive(true);
		}
	}
}
