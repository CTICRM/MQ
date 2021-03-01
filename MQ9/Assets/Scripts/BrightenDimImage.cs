using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightenDimImage : MonoBehaviour
{
    public Image map;
	public Button dim;
	public Button brighten;
	public Button dimDropdown;
	public Button brightenDropdown;
	Color32 dimmest = new Color32(15, 15, 15, 255);
	Color32 dimPlusOne = new Color32(55, 55, 55, 255);
	Color32 dimPlusTwo = new Color32(95, 95, 95, 255);
	Color32 middle = new Color32(135, 135, 135, 255);
	Color32 maxMinusTwo = new Color32(175, 175, 175, 255);
	Color32 maxMinusOne = new Color32(215, 215, 215, 255);
	Color32 max = new Color32(255, 255, 255, 255);
    // Start is called before the first frame update
    void Start()
    {
        map.GetComponent<Image>().color = middle;
		dim.GetComponent<Button>().interactable = true;
		brighten.GetComponent<Button>().interactable = true;
		dimDropdown.GetComponent<Button>().interactable = true;
		brightenDropdown.GetComponent<Button>().interactable = true;
    }

    public void dimMap() {
		if (map.GetComponent<Image>().color == max) {
			map.GetComponent<Image>().color = maxMinusOne;
			brighten.GetComponent<Button>().interactable = true;
			brightenDropdown.GetComponent<Button>().interactable = true;
		}
		else if (map.GetComponent<Image>().color == maxMinusOne) {
			map.GetComponent<Image>().color = maxMinusTwo;
		}
		else if (map.GetComponent<Image>().color == maxMinusTwo) {
			map.GetComponent<Image>().color = middle;
		}
		else if (map.GetComponent<Image>().color == middle) {
			map.GetComponent<Image>().color = dimPlusTwo;
		}
		else if (map.GetComponent<Image>().color == dimPlusTwo) {
			map.GetComponent<Image>().color = dimPlusOne;
		}
		else if (map.GetComponent<Image>().color == dimPlusOne) {
			map.GetComponent<Image>().color = dimmest;
			dim.GetComponent<Button>().interactable = false;
			dimDropdown.GetComponent<Button>().interactable = false;
		}
	}
	
	public void brightenMap() {
		if (map.GetComponent<Image>().color == dimmest) {
			map.GetComponent<Image>().color = dimPlusOne;
			dim.GetComponent<Button>().interactable = true;
			dimDropdown.GetComponent<Button>().interactable = true;
		}
		else if (map.GetComponent<Image>().color == dimPlusOne) {
			map.GetComponent<Image>().color = dimPlusTwo;
		}
		else if (map.GetComponent<Image>().color == dimPlusTwo) {
			map.GetComponent<Image>().color = middle;
		}
		else if (map.GetComponent<Image>().color == middle) {
			map.GetComponent<Image>().color = maxMinusTwo;
		}
		else if (map.GetComponent<Image>().color == maxMinusTwo) {
			map.GetComponent<Image>().color = maxMinusOne;
		}
		else if (map.GetComponent<Image>().color == maxMinusOne) {
			map.GetComponent<Image>().color = max;
			brighten.GetComponent<Button>().interactable = false;
			brightenDropdown.GetComponent<Button>().interactable = false;
		}
	}
}
