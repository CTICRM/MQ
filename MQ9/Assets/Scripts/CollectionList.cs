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
	public GameObject errorIDPopup;
	//GameObject newEntry;
	List<GameObject> createdEntries = new List<GameObject>();
	GameObject[] array;
	List<string> usedIDs = new List<string>();
	float posY = 0.0f;
	
	public void addEntry() {
		if (!usedIDs.Contains(id.text)) {
			usedIDs.Add(id.text);
			GameObject newEntry = Instantiate(collectionListEntryPrefab);
			newEntry.transform.parent = collectionListEntryPanel.transform;
			newEntry.transform.localPosition = new Vector3(0, posY, 0);
			posY -= 70.0f;
			GameObject.Find("ID Data Text").GetComponent<Text>().text = id.text;
			/* collectionListEntryPrefab.SetParent(collectionListEntryPanel);
			Instantiate(collectionListEntryPrefab, new Vector3(0, posY, 0), Quaternion.identity);
			posY -= 100.0f;
			collectionListEntryPrefab.Find("ID Data Text").GetComponent<Text>().text = id.text; */
		}
		else {
			errorIDPopup.SetActive(true);
		}
	}
	
	/* public void addEntry() {
		if (!usedIDs.Contains(id.text)) {
			GameObject newItemInList = Instantiate(collectionListEntryPrefab);
			newItemInList.transform.parent = collectionListEntryPanel.transform;
			newItemInList.transform.localPosition = new Vector3(0, posY, 0);
			posY -= 70.0f;
			string idText = id.text;
			Text typeText = "";
			string hiddenText = "False";
			string remarksText = remarks.text;
			GameObject.Find("ID Data Text").GetComponent<Text>().text = idText;
			GameObject.Find("Type Data Text").GetComponent<Text>().text = "";
			GameObject.Find("Hidden Data Text").GetComponent<Text>().text = hiddenText;
			GameObject.Find("Remarks Data Text").GetComponent<Text>().text = remarksText;
			usedIDs.Add(idText);
			array = GameObject.FindGameObjectsWithTag("Entry");
			Destroy(newItemInList);
			for (i = 0; i < array.Length; i++) {
				createdEntries.Add(array[i]);
			}
			foreach (GameObject item in createdEntries) {
				Instantiate(item);
				item.transform.parent = collectionListEntryPanel.transform;
				item.transform.localPosition = new Vector3(0, posY, 0);
			}
		}
		else {
			errorIDPopup.SetActive(true);
		}
	} */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
