using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnerdyneVideoControls : MonoBehaviour
{
	public Slider brightness;
	public Text brightnessValueText;
	public Slider contrast;
	public Text contrastValueText;
	public Slider hue;
	public Text hueValueText;
	public Button qualityFactorOne;
	public Button qualityFactorTwo;
	public Button qualityFactorThree;
	public Button qualityFactorFour;
	public Button mono;
	public Button color;
	Color32 onBlack = new Color32(0, 0, 0, 255);
	Color32 offWhite = new Color32(255, 255, 255, 255);
    // Start is called before the first frame update
    void Start()
    {
        //brightness.GetComponent<Slider>().value = 0.5f;
		//brightnessValueText.text = "50";
		//contrast.GetComponent<Slider>().value = 0.5f;
		//contrastValueText.text = "50";
		//hue.GetComponent<Slider>().value = 0.5f;
		//hueValueText.text = "0";
    }
	
	public void brightnessTextUpdate(float value) {
		//float currValue = Mathf.Log10(value) * 20;
		//brightnessValueText.text = currValue.ToString();
		brightnessValueText.text = Mathf.RoundToInt(value / 10).ToString();
		//brightnessValueText.text = value.ToString();
	}
	
	public void contrastTextUpdate(float value) {
		//float currValue = Mathf.Log10(value) * 20;
		//contrastValueText.text = currValue.ToString();
		contrastValueText.text = Mathf.RoundToInt(value).ToString();
	}
	
	public void hueTextUpdate(float value) {
		float currValue = Mathf.Log10(value) * 20;
		hueValueText.text = currValue.ToString();
	}
	
	public void qualityFactorOneClick() {
		qualityFactorOne.GetComponent<Image>().color = onBlack;
		qualityFactorTwo.GetComponent<Image>().color = offWhite;
		qualityFactorThree.GetComponent<Image>().color = offWhite;
		qualityFactorFour.GetComponent<Image>().color = offWhite;
	}
	
	public void qualityFactorTwoClick() {
		qualityFactorOne.GetComponent<Image>().color = offWhite;
		qualityFactorTwo.GetComponent<Image>().color = onBlack;
		qualityFactorThree.GetComponent<Image>().color = offWhite;
		qualityFactorFour.GetComponent<Image>().color = offWhite;
	}
	
	public void qualityFactorThreeClick() {
		qualityFactorOne.GetComponent<Image>().color = offWhite;
		qualityFactorTwo.GetComponent<Image>().color = offWhite;
		qualityFactorThree.GetComponent<Image>().color = onBlack;
		qualityFactorFour.GetComponent<Image>().color = offWhite;
	}
	
	public void qualityFactorFourClick() {
		qualityFactorOne.GetComponent<Image>().color = offWhite;
		qualityFactorTwo.GetComponent<Image>().color = offWhite;
		qualityFactorThree.GetComponent<Image>().color = offWhite;
		qualityFactorFour.GetComponent<Image>().color = onBlack;
	}
	
	public void monoClick() {
		mono.GetComponent<Image>().color = onBlack;
		color.GetComponent<Image>().color = offWhite;
	}
	
	public void colorClick() {
		mono.GetComponent<Image>().color = offWhite;
		color.GetComponent<Image>().color = onBlack;
	}
	
	public void resetEncoder() {
		qualityFactorTwoClick();
		colorClick();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
