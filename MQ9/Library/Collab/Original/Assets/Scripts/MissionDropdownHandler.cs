using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionDropdownHandler : MonoBehaviour
{
	public Dropdown ddCollectionMode;
	public GameObject missionWaypointEditor;
	public GameObject missionPayloadControls;
	public GameObject pointOption;
	public GameObject sweepOption;
	public GameObject missionMissionEditor;
	public GameObject missionNew;
	public GameObject missionClear;
	public GameObject missionUploadSelected;
	public GameObject missionDownloadOpMission;
	public GameObject missionDownloadEmMission;
    // Start is called before the first frame update
    private void Start()
    {	
		ddCollectionMode.onValueChanged.AddListener(delegate {
			ddCollectionValueChange(ddCollectionMode);
		});
    }
	
	public void ddCollectionValueChange(Dropdown sender) {
		if (sender.options[sender.value].text == "Point") {
			pointOption.SetActive(true);
			sweepOption.SetActive(false);
		}
		else if (sender.options[sender.value].text == "Sweep") {
			pointOption.SetActive(false);
			sweepOption.SetActive(true);
		}
	}
}
