using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Turns off any popups with the "Dialog" tag

public class DismissDialogs : MonoBehaviour
{
	GameObject[] dialogs;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	// Checks for any active popups with the "Dialog" tag when the emulator is on
	void Update() {
		dialogs = GameObject.FindGameObjectsWithTag("Dialog");
	}
	
	// Turns the dialog popup's active status from true to false
	public void turnOffActiveDialogs() {
		foreach(GameObject dialog in dialogs) {
			dialog.SetActive(false);
		}
	}
}