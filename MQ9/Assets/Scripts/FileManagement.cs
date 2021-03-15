using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileManagement : MonoBehaviour
{
	public Button ppo1;
	public Button ppo2;
	public Button missions;
	public Button maps;
	public Button collectionList;
	public Button presets;
	public Button logs;
	public Button dted;
	public Button copy;
	public Button delete;
	public string topRightTitleText;
	/* public GameObject missionsOption;
	public GameObject mapsOption;
	public GameObject collectionListOption;
	public GameObject presetsOption;
	public GameObject logsOption;
	public GameObject dtedOption; */
	Color32 onBlack = new Color32(0, 0, 0, 255);
	Color32 offWhite = new Color32(255, 255, 255, 255);
	Color32 selectedGreen = new Color32(0, 255, 15, 255);
	Color32 notSelectedGray = new Color32(207, 207, 207, 255);
    // Start is called before the first frame update
    void Start()
    {
        topRightTitleText = "ppo2";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void ppo1Click() {
		ppo1.GetComponent<Image>().color = selectedGreen;
		ppo2.GetComponent<Image>().color = notSelectedGray;
		topRightTitleText = "ppo1";
	}
	
	public void ppo2Click() {
		ppo1.GetComponent<Image>().color = notSelectedGray;
		ppo2.GetComponent<Image>().color = selectedGreen;
		topRightTitleText = "ppo2";
	}
	
	public void missionsClick() {
		missions.GetComponent<Image>().color = onBlack;
		maps.GetComponent<Image>().color = offWhite;
		collectionList.GetComponent<Image>().color = offWhite;
		presets.GetComponent<Image>().color = offWhite;
		logs.GetComponent<Image>().color = offWhite;
		dted.GetComponent<Image>().color = offWhite;
	}
	
	public void mapsClick() {
		missions.GetComponent<Image>().color = offWhite;
		maps.GetComponent<Image>().color = onBlack;
		collectionList.GetComponent<Image>().color = offWhite;
		presets.GetComponent<Image>().color = offWhite;
		logs.GetComponent<Image>().color = offWhite;
		dted.GetComponent<Image>().color = offWhite;
	}
	
	public void collectionListClick() {
		missions.GetComponent<Image>().color = offWhite;
		maps.GetComponent<Image>().color = offWhite;
		collectionList.GetComponent<Image>().color = onBlack;
		presets.GetComponent<Image>().color = offWhite;
		logs.GetComponent<Image>().color = offWhite;
		dted.GetComponent<Image>().color = offWhite;
	}
	
	public void presetsClick() {
		missions.GetComponent<Image>().color = offWhite;
		maps.GetComponent<Image>().color = offWhite;
		collectionList.GetComponent<Image>().color = offWhite;
		presets.GetComponent<Image>().color = onBlack;
		logs.GetComponent<Image>().color = offWhite;
		dted.GetComponent<Image>().color = offWhite;
	}
	
	public void logsClick() {
		missions.GetComponent<Image>().color = offWhite;
		maps.GetComponent<Image>().color = offWhite;
		collectionList.GetComponent<Image>().color = offWhite;
		presets.GetComponent<Image>().color = offWhite;
		logs.GetComponent<Image>().color = onBlack;
		dted.GetComponent<Image>().color = offWhite;
	}
	
	public void dtedClick() {
		missions.GetComponent<Image>().color = offWhite;
		maps.GetComponent<Image>().color = offWhite;
		collectionList.GetComponent<Image>().color = offWhite;
		presets.GetComponent<Image>().color = offWhite;
		logs.GetComponent<Image>().color = offWhite;
		dted.GetComponent<Image>().color = onBlack;
	}
}
