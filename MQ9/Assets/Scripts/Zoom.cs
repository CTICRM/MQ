using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour
{
    public Image map;
	public Button zoomIn;
	public Button zoomOut;
	public Button zoomInDropdown;
	public Button zoomOutDropdown;
	Vector3 min = new Vector3(1.0f, 1.0f, 1.0f);
	Vector3 minPlusOne = new Vector3(1.2f, 1.2f, 1.2f);
	Vector3 minPlusTwo = new Vector3(1.4f, 1.4f, 1.4f);
	Vector3 middle = new Vector3(1.6f, 1.6f, 1.6f);
	Vector3 maxMinusTwo = new Vector3(1.7f, 1.8f, 1.8f);
	Vector3 maxMinusOne = new Vector3(2.0f, 2.0f, 2.0f);
	Vector3 max = new Vector3(2.2f, 2.2f, 2.2f);
    // Start is called before the first frame update
    void Start()
    {
        //map.rectTransform.localScale = max;
		zoomIn.GetComponent<Button>().interactable = false;
		zoomOut.GetComponent<Button>().interactable = true;
		zoomInDropdown.GetComponent<Button>().interactable = false;
		zoomOutDropdown.GetComponent<Button>().interactable = true;
    }
	
	public void zoomOutMap() {
		if (map.rectTransform.localScale == max) {
			map.rectTransform.localScale = maxMinusOne;
			zoomIn.GetComponent<Button>().interactable = true;
			zoomInDropdown.GetComponent<Button>().interactable = true;
		}
		else if (map.rectTransform.localScale == maxMinusOne) {
			map.rectTransform.localScale = maxMinusTwo;
		}
		else if (map.rectTransform.localScale == maxMinusTwo) {
			map.rectTransform.localScale = middle;
		}
		else if (map.rectTransform.localScale == middle) {
			map.rectTransform.localScale = minPlusTwo;
		}
		else if (map.rectTransform.localScale == minPlusTwo) {
			map.rectTransform.localScale = minPlusOne;
		}
		else if (map.rectTransform.localScale == minPlusOne) {
			map.rectTransform.localScale = min;
			zoomOut.GetComponent<Button>().interactable = false;
			zoomOutDropdown.GetComponent<Button>().interactable = false;
		}
	}
	
	public void zoomInMap() {
		if (map.rectTransform.localScale == min) {
			map.rectTransform.localScale = minPlusOne;
			zoomOut.GetComponent<Button>().interactable = true;
			zoomOutDropdown.GetComponent<Button>().interactable = true;
		}
		else if (map.rectTransform.localScale == minPlusOne) {
			map.rectTransform.localScale = minPlusTwo;
		}
		else if (map.rectTransform.localScale == minPlusTwo) {
			map.rectTransform.localScale = middle;
		}
		else if (map.rectTransform.localScale == middle) {
			map.rectTransform.localScale = maxMinusTwo;
		}
		else if (map.rectTransform.localScale == maxMinusTwo) {
			map.rectTransform.localScale = maxMinusOne;
		}
		else if (map.rectTransform.localScale == maxMinusOne) {
			map.rectTransform.localScale = max;
			zoomIn.GetComponent<Button>().interactable = false;
			zoomInDropdown.GetComponent<Button>().interactable = false;
		}
	}
}
