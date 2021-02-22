using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    GameObject map;
	float posX;
	float posY;
	float posZ;
	
	void Start() {
		map = GameObject.Find("Map Image");
	}
	
	void Update() {
		posX = map.transform.position.x;
		posY = map.transform.position.y;
		posZ = map.transform.position.z;
	}
    
	public void goUp() {
		map.transform.position = new Vector3(posX, posY - 44, posZ);
	}
	
	public void goDown() {
		map.transform.position = new Vector3(posX, posY + 44, posZ);
	}
	
	public void goRight() {
		map.transform.position = new Vector3(posX - 44, posY, posZ);
	}
	
	public void goLeft() {
		map.transform.position = new Vector3(posX + 44, posY, posZ);
	}
}
