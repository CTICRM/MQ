using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Houses all of the functions seen in the Mission Editor popup

public class MissionEditor : MonoBehaviour
{
	public Button opButton;
	public Button emButton;
	public Button leftButton;
	public Button rightButton;
	public InputField waypointInput;
	Color32 onColor = new Color32(0, 0, 0, 255); // The button is the selected one
	Color32 offColor = new Color32(255, 255, 255, 255); // The buttons is not the selected one
	
	public void opChosen() {
		opButton.GetComponent<Image>().color = onColor;
		emButton.GetComponent<Image>().color = offColor;
	}
	
	public void emChosen() {
		opButton.GetComponent<Image>().color = offColor;
		emButton.GetComponent<Image>().color = onColor;
	}
	
	public void leftClick() {
		if (waypointInput.text == "003") {
			waypointInput.text = "002";
			rightButton.GetComponent<Button>().interactable = true;
		}
		else if (waypointInput.text == "002") {
			waypointInput.text = "001";
			leftButton.GetComponent<Button>().interactable = false;
		}
	}
	
	public void rightClick() {
		if (waypointInput.text == "001") {
			waypointInput.text = "002";
			leftButton.interactable = true;
		}
		else if (waypointInput.text == "002") {
			waypointInput.text = "003";
			rightButton.interactable = false;
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        leftButton.GetComponent<Button>().interactable = false;
		rightButton.GetComponent<Button>().interactable = true;
		waypointInput.text = "001";
    }
}
