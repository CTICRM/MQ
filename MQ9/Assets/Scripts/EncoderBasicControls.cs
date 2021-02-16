using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncoderBasicControls : MonoBehaviour
{
	public InputField minQuantIInput;
	public InputField maxQuantIInput;
	public InputField minQuantPInput;
	public Button minQuantPUp;
	public Button minQuantPDown;
	public InputField maxQuantPInput;
	public Button maxQuantPUp;
	public Button maxQuantPDown;
	public Button align;
	public Button auto;
	static int minQuantIValue = 5;
	static int minQuantPValue = 5;
	static int maxQuantIValue = 50;
	static int maxQuantPValue = 50;
	Color32 onColor = new Color32(0, 0, 0, 255);
	Color32 offColor = new Color32(255, 255, 255, 255);
	
	void Start() {
		minQuantIInput.text = minQuantIValue.ToString();
		maxQuantIInput.text = maxQuantIValue.ToString();
		minQuantPInput.text = minQuantPValue.ToString();
		maxQuantPInput.text = maxQuantPValue.ToString();
	}
    
	public void changeAlign() {
		if (align.GetComponent<Image>().color == onColor) {
			minQuantPInput.interactable = false;
			minQuantPUp.interactable = false;
			minQuantPDown.interactable = false;
			maxQuantPInput.interactable = false;
			maxQuantPUp.interactable = false;
			maxQuantPDown.interactable = false;
			align.GetComponent<Image>().color = offColor;
		}
		else {
			minQuantPInput.interactable = true;
			minQuantPUp.interactable = true;
			minQuantPDown.interactable = true;
			maxQuantPInput.interactable = true;
			maxQuantPUp.interactable = true;
			maxQuantPDown.interactable = true;
			align.GetComponent<Image>().color = onColor;
		}
	}
	
	public void changeAuto() {
		if (auto.GetComponent<Image>().color == onColor) {
			auto.GetComponent<Image>().color = offColor;
		}
		else {
			auto.GetComponent<Image>().color = onColor;
		}
	}
	
	public void minQuantIIncrement() {
		minQuantIValue++;
		minQuantIInput.text = minQuantIValue.ToString();
	}
	
	public void minQuantIDecrement() {
		minQuantIValue--;
		if (minQuantIValue <= 0) {
			minQuantIValue = 0;
		}
		minQuantIInput.text = minQuantIValue.ToString();
	}
	
	public void maxQuantIIncrement() {
		maxQuantIValue++;
		maxQuantIInput.text = maxQuantIValue.ToString();
	}
	
	public void maxQuantIDecrement() {
		maxQuantIValue--;
		if (maxQuantIValue <= 0) {
			maxQuantIValue = 0;
		}
		maxQuantIInput.text = maxQuantIValue.ToString();
	}
	
	public void minQuantPIncrement() {
		minQuantPValue++;
		minQuantPInput.text = minQuantPValue.ToString();
	}
	
	public void minQuantPDecrement() {
		minQuantPValue--;
		if (minQuantPValue <= 0) {
			minQuantPValue = 0;
		}
		minQuantPInput.text = minQuantPValue.ToString();
	}
	
	public void maxQuantPIncrement() {
		maxQuantPValue++;
		maxQuantPInput.text = maxQuantPValue.ToString();
	}
	
	public void maxQuantPDecrement() {
		maxQuantPValue--;
		if (maxQuantPValue <= 0) {
			maxQuantPValue = 0;
		}
		maxQuantPInput.text = maxQuantPValue.ToString();
	}
}
