using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DismissDialogs : MonoBehaviour
{
	GameObject[] dialogs;
	
    // Start is called before the first frame update
    void Start()
    {
        dialogs = GameObject.FindGameObjectsWithTag("Dialog");
		foreach (GameObject dialog in dialogs) {
			dialog.SetActive(false);
		}
    }
	
	public void turnOffActiveDialogs() {
		foreach(GameObject dialog in dialogs) {
			dialog.SetActive(false);
		}
	}
}