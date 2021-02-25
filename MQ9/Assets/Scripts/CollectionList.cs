using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionList : MonoBehaviour
{
	public InputField id;
	public InputField remarks;
	//public Dropdown coordinateSystem;
	public InputField latitudeSec;
	public InputField longitudeSec;
	/* public InputField latitudeMin;
	public InputField longitudeMin;
	public InputField mgrs;
	public InputField utm; */
	/* public Text idData;
	public Text typeData;
	public Text hiddenData;
	public Text remarksData; */
	public GameObject collectionListEntryPanel;
	public GameObject collectionListEntryPrefab;
	//int[] usedIDs;
	float posY = -144.0f;

	public void addEntry() {
		GameObject newItemInList = Instantiate(collectionListEntryPrefab);
		newItemInList.transform.parent = collectionListEntryPanel.transform;
		newItemInList.transform.localPosition = new Vector3(0, posY, 0);
		posY -= 100.0f;
		string idText = id.text;
		//Text typeText = "";
		string hiddenText = "False";
		string remarksText = remarks.text;
		GameObject.Find("ID Data Text").GetComponent<Text>().text = idText;
		//GameObject.Find("Type Data Text").GetComponent<Text>().text = "";
		GameObject.Find("Hidden Data Text").GetComponent<Text>().text = hiddenText;
		GameObject.Find("Remarks Data Text").GetComponent<Text>().text = remarksText;
		//Instantiate(collectionListEntry, new Vector3(0, 
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
