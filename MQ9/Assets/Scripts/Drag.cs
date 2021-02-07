using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
	GameObject trackerCursorImage;
	float posX;
	float posY;
	
	void Start() {
		trackerCursorImage = GameObject.Find("Tracker Cursor Image");
	}
	
    public void dragCursor() {
		trackerCursorImage.transform.position = Input.mousePosition;
		posX = Input.mousePosition.x;
		posY = Input.mousePosition.y;
	}
	
	void OnMouseUp() {
		if ((posX > 646 || posX < 236) || (posY > 432 || posY < 21)) {
			trackerCursorImage.transform.position = new Vector3(-10, -20, -8.2f);
			Debug.Log("Worked!");
		}
	}
}
