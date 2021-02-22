using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PayloadsDropdownHandler : MonoBehaviour
{
	public Button leftUAVGPOne;
	public Button leftUAVGPTwo;
	public Button leftUAVGPThree;
	public Button rightUAVGPOne;
	public Button rightUAVGPTwo;
	public Button rightUAVGPThree;
	public GameObject genericPayloadConfig;
	Color32 optionOn = new Color32(0, 0, 0, 255);
	Color32 optionOff = new Color32(255, 255, 255, 255);
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	public void leftUAVGPOneOn() {
		leftUAVGPOne.GetComponent<Image>().color = optionOn;
		leftUAVGPTwo.GetComponent<Image>().color = optionOff;
		leftUAVGPThree.GetComponent<Image>().color = optionOff;
	}
	
	public void leftUAVGPTwoOn() {
		leftUAVGPOne.GetComponent<Image>().color = optionOff;
		leftUAVGPTwo.GetComponent<Image>().color = optionOn;
		leftUAVGPThree.GetComponent<Image>().color = optionOff;
	}
	
	public void leftUAVGPThreeOn() {
		leftUAVGPOne.GetComponent<Image>().color = optionOff;
		leftUAVGPTwo.GetComponent<Image>().color = optionOff;
		leftUAVGPThree.GetComponent<Image>().color = optionOn;
	}
	
	public void rightUAVGPOneOn() {
		rightUAVGPOne.GetComponent<Image>().color = optionOn;
		rightUAVGPTwo.GetComponent<Image>().color = optionOff;
		rightUAVGPThree.GetComponent<Image>().color = optionOff;
	}
	
	public void rightUAVGPTwoOn() {
		rightUAVGPOne.GetComponent<Image>().color = optionOff;
		rightUAVGPTwo.GetComponent<Image>().color = optionOn;
		rightUAVGPThree.GetComponent<Image>().color = optionOff;
	}
	
	public void rightUAVGPThreeOn() {
		rightUAVGPOne.GetComponent<Image>().color = optionOff;
		rightUAVGPTwo.GetComponent<Image>().color = optionOff;
		rightUAVGPThree.GetComponent<Image>().color = optionOn;
	}
}
