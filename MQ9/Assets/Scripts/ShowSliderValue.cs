using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Deals with the slider functionality seen in the 
// Enerdyne Video Controls popup

public class ShowSliderValue : MonoBehaviour
{
	public Slider brightness;
	public Slider contrast;
	public Slider hue;
	public Text brightnessValueText;
	public Text contrastValueText;
	public Text hueValueText;
    // Start is called before the first frame update
    void Start()
    {
        /* brightness.GetComponent<Slider>().value = 0.5f;
		contrast.GetComponent<Slider>().value = 0.5f;
		hue.GetComponent<Slider>().value = 0.5f; */
    }
	
	public void brightnessTextUpdate(float value) {
		float currValue = Mathf.RoundToInt(value * 100);
		brightnessValueText.text = currValue.ToString();
	}
	
	public void contrastTextUpdate(float value) {
		float currValue = Mathf.RoundToInt(value * 100);
		contrastValueText.text = currValue.ToString();
	}
	
	public void hueTextUpdate(float value) {
		float currValue = Mathf.RoundToInt(value * 100);
		hueValueText.text = currValue.ToString();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
