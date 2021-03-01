using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DVRSettings : MonoBehaviour
{
	public Button uplinkEnabled;
	public Button uplinkDisabled;
	public Button downlinkEnabled;
	public Button downlinkDisabled;
	public InputField playbackSettings_multicastAddress;
	public InputField playbackSettings_uplinkAddress;
	public InputField playbackSettings_downlinkAddress;
	public InputField timeToLive;
	public Button timeToLiveDown;
	public InputField recordSettings_multicastAddress;
	public InputField recordSettings_uplinkAddress;
	public InputField recordSettings_downlinkAddress;
	static int timeToLiveValue = 3;
	Color32 onColor = new Color32(0, 0, 0, 255);
	Color32 offColor = new Color32(255, 255, 255, 255);
	
    // Start is called before the first frame update
    void Start()
    {
        playbackSettings_multicastAddress.text = "238 .1 .1";
		playbackSettings_uplinkAddress.text = "238 .1 .1";
		playbackSettings_downlinkAddress.text = "238 .1 .1";
		timeToLive.text = timeToLiveValue.ToString();
		recordSettings_multicastAddress.text = "238 .1 .1";
		recordSettings_uplinkAddress.text = "238 .1 .1";
		recordSettings_downlinkAddress.text = "238 .1 .1";
    }
	
	public void uplinkPlaybackEnabled() {
		uplinkEnabled.GetComponent<Image>().color = onColor;
		uplinkDisabled.GetComponent<Image>().color = offColor;
	}
	
	public void uplinkPlaybackDisabled() {
		uplinkEnabled.GetComponent<Image>().color = offColor;
		uplinkDisabled.GetComponent<Image>().color = onColor;
	}
	
	public void downlinkPlaybackEnabled() {
		downlinkEnabled.GetComponent<Image>().color = onColor;
		downlinkDisabled.GetComponent<Image>().color = offColor;
	}
	
	public void downlinkPlaybackDisabled() {
		downlinkEnabled.GetComponent<Image>().color = offColor;
		downlinkDisabled.GetComponent<Image>().color = onColor;
	}
	
	public void timeToLiveIncrement() {
		timeToLiveValue++;
		timeToLiveDown.interactable = true;
		timeToLive.text = timeToLiveValue.ToString();
	}
	
	public void timeToLiveDecrement() {
		timeToLiveValue--;
		if (timeToLiveValue <= 0) {
			timeToLiveDown.interactable = false;
		}
		timeToLive.text = timeToLiveValue.ToString();
	}
}
