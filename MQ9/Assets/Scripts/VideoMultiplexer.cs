using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoMultiplexer : MonoBehaviour
{
	public Button noseED_SATCOMOne;
	public Button noseED_SATCOMTwo;
	public Button noseIR_SATCOMOne;
	public Button noseIR_SATCOMTwo;
	public Button mtsB_SATCOMOne;
	public Button mtsB_SATCOMTwo;
	public Button intOne_SATCOM;
	public Button intTwo_SATCOM;
	public Button extTwo;
	public Button noseED_CBandOne;
	public Button noseED_CBandTwo;
	public Button noseED_CBandThree;
	public Button noseIR_CBandOne;
	public Button noseIR_CBandTwo;
	public Button noseIR_CBandThree;
	public Button mtsB_CBandOne;
	public Button mtsB_CBandTwo;
	public Button mtsB_CBandThree;
	public Button txOne;
	public Button txTwo;
	public Button noseED_COLUPPERLOSOne;
	public Button noseED_COLUPPERLOSTwo;
	public Button noseIR_COLUPPERLOSOne;
	public Button noseIR_COLUPPERLOSTwo;
	public Button mtsB_COLUPPERLOSOne;
	public Button mtsB_COLUPPERLOSTwo;
	public Button intOne_COLUPPERLOS;
	public Button intTwo_COLUPPERLOS;
	public Button noseED_COLLOWERLOSOne;
	public Button noseED_COLLOWERLOSTwo;
	public Button noseIR_COLLOWERLOSOne;
	public Button noseIR_COLLOWERLOSTwo;
	public Button mtsB_COLLOWERLOSOne;
	public Button mtsB_COLLOWERLOSTwo;
	public Button intOne_COLLOWERLOS;
	public Button intTwo_COLLOWERLOS;
	public GameObject dvrHUD;
	public GameObject dvrIntOne_SATCOM;
	public GameObject dvrIntTwo_SATCOM;
	public GameObject dvrExtTwo;
	public GameObject dvrTxOne;
	public GameObject dvrTxTwo;
	public GameObject dvrIntOne_COLUPPERLOS;
	public GameObject dvrIntTwo_COLUPPERLOS;
	public GameObject dvrIntOne_COLLOWERLOS;
	public GameObject dvrIntTwo_COLLOWERLOS;
	public GameObject hudIntOne_SATCOM;
	public GameObject hudIntTwo_SATCOM;
	public GameObject hudExtTwo;
	public GameObject hudTxOne;
	public GameObject hudTxTwo;
	public GameObject hudIntOne_COLUPPERLOS;
	public GameObject hudIntTwo_COLUPPERLOS;
	public GameObject hudIntOne_COLLOWERLOS;
	public GameObject hudIntTwo_COLLOWERLOS;
	Color32 hudGreen = new Color32(1, 113, 0, 255);
	Color32 dvrOrange = new Color32(255, 107, 0, 255);
	Color32 onBlue = new Color32(3, 0, 255, 255);
	Color32 offGray = new Color32(207, 207, 207, 255);
	Color32 waitingYellow = new Color32(216, 255, 0, 255);
	string currHUDActive;
	string currDVRActive;
    // Start is called before the first frame update
    void Start()
    {
		currHUDActive = "HUD -> EXT2";
		currDVRActive = "DVR -> HUD";
    }
	
	public void noseED_SATCOMOne_Chosen() {
		if (noseED_SATCOMOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_SATCOMOne.GetComponent<Image>().color = onBlue;
			noseIR_SATCOMOne.GetComponent<Image>().color = offGray;
			mtsB_SATCOMOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_SATCOMTwo_Chosen() {
		if (noseED_SATCOMTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_SATCOMTwo.GetComponent<Image>().color = onBlue;
			noseIR_SATCOMTwo.GetComponent<Image>().color = offGray;
			mtsB_SATCOMTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_CBandOne_Chosen() {
		if (noseED_CBandOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandOne.GetComponent<Image>().color = onBlue;
			noseIR_CBandOne.GetComponent<Image>().color = offGray;
			mtsB_CBandOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_CBandTwo_Chosen() {
		if (noseED_CBandTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandTwo.GetComponent<Image>().color = onBlue;
			noseIR_CBandTwo.GetComponent<Image>().color = offGray;
			mtsB_CBandTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_CBandThree_Chosen() {
		if (noseED_CBandThree.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandThree.GetComponent<Image>().color = onBlue;
			noseIR_CBandThree.GetComponent<Image>().color = offGray;
			mtsB_CBandThree.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_COLUPPERLOSOne_Chosen() {
		if (noseED_COLUPPERLOSOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLUPPERLOSOne.GetComponent<Image>().color = onBlue;
			noseIR_COLUPPERLOSOne.GetComponent<Image>().color = offGray;
			mtsB_COLUPPERLOSOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_COLUPPERLOSTwo_Chosen() {
		if (noseED_COLUPPERLOSTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLUPPERLOSTwo.GetComponent<Image>().color = onBlue;
			noseIR_COLUPPERLOSTwo.GetComponent<Image>().color = offGray;
			mtsB_COLUPPERLOSTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_COLLOWERLOSOne_Chosen() {
		if (noseED_COLLOWERLOSOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLLOWERLOSOne.GetComponent<Image>().color = onBlue;
			noseIR_COLLOWERLOSOne.GetComponent<Image>().color = offGray;
			mtsB_COLLOWERLOSOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseED_COLLOWERLOSTwo_Chosen() {
		if (noseED_COLLOWERLOSTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLLOWERLOSTwo.GetComponent<Image>().color = onBlue;
			noseIR_COLLOWERLOSTwo.GetComponent<Image>().color = offGray;
			mtsB_COLLOWERLOSTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_SATCOMOne_Chosen() {
		if (noseIR_SATCOMOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_SATCOMOne.GetComponent<Image>().color = offGray;
			noseIR_SATCOMOne.GetComponent<Image>().color = onBlue;
			mtsB_SATCOMOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_SATCOMTwo_Chosen() {
		if (noseIR_SATCOMTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_SATCOMTwo.GetComponent<Image>().color = offGray;
			noseIR_SATCOMTwo.GetComponent<Image>().color = onBlue;
			mtsB_SATCOMTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_CBandOne_Chosen() {
		if (noseIR_CBandOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandOne.GetComponent<Image>().color = offGray;
			noseIR_CBandOne.GetComponent<Image>().color = onBlue;
			mtsB_CBandOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_CBandTwo_Chosen() {
		if (noseIR_CBandTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandTwo.GetComponent<Image>().color = offGray;
			noseIR_CBandTwo.GetComponent<Image>().color = onBlue;
			mtsB_CBandTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_CBandThree_Chosen() {
		if (noseIR_CBandThree.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandThree.GetComponent<Image>().color = offGray;
			noseIR_CBandThree.GetComponent<Image>().color = onBlue;
			mtsB_CBandThree.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_COLUPPERLOSOne_Chosen() {
		if (noseIR_COLUPPERLOSOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLUPPERLOSOne.GetComponent<Image>().color = offGray;
			noseIR_COLUPPERLOSOne.GetComponent<Image>().color = onBlue;
			mtsB_COLUPPERLOSOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_COLUPPERLOSTwo_Chosen() {
		if (noseIR_COLUPPERLOSTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLUPPERLOSTwo.GetComponent<Image>().color = offGray;
			noseIR_COLUPPERLOSTwo.GetComponent<Image>().color = onBlue;
			mtsB_COLUPPERLOSTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_COLLOWERLOSOne_Chosen() {
		if (noseIR_COLLOWERLOSOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLLOWERLOSOne.GetComponent<Image>().color = offGray;
			noseIR_COLLOWERLOSOne.GetComponent<Image>().color = onBlue;
			mtsB_COLLOWERLOSOne.GetComponent<Image>().color = offGray;
		}
	}
	
	public void noseIR_COLLOWERLOSTwo_Chosen() {
		if (noseIR_COLLOWERLOSTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLLOWERLOSTwo.GetComponent<Image>().color = offGray;
			noseIR_COLLOWERLOSTwo.GetComponent<Image>().color = onBlue;
			mtsB_COLLOWERLOSTwo.GetComponent<Image>().color = offGray;
		}
	}
	
	public void mtsB_SATCOMOne_Chosen() {
		if (mtsB_SATCOMOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_SATCOMOne.GetComponent<Image>().color = offGray;
			noseIR_SATCOMOne.GetComponent<Image>().color = offGray;
			mtsB_SATCOMOne.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_SATCOMTwo_Chosen() {
		if (mtsB_SATCOMTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_SATCOMTwo.GetComponent<Image>().color = offGray;
			noseIR_SATCOMTwo.GetComponent<Image>().color = offGray;
			mtsB_SATCOMTwo.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_CBandOne_Chosen() {
		if (mtsB_CBandOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandOne.GetComponent<Image>().color = offGray;
			noseIR_CBandOne.GetComponent<Image>().color = offGray;
			mtsB_CBandOne.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_CBandTwo_Chosen() {
		if (mtsB_CBandTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandTwo.GetComponent<Image>().color = offGray;
			noseIR_CBandTwo.GetComponent<Image>().color = offGray;
			mtsB_CBandTwo.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_CBandThree_Chosen() {
		if (mtsB_CBandThree.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_CBandThree.GetComponent<Image>().color = offGray;
			noseIR_CBandThree.GetComponent<Image>().color = offGray;
			mtsB_CBandThree.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_COLUPPERLOSOne_Chosen() {
		if (mtsB_COLUPPERLOSOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLUPPERLOSOne.GetComponent<Image>().color = offGray;
			noseIR_COLUPPERLOSOne.GetComponent<Image>().color = offGray;
			mtsB_COLUPPERLOSOne.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_COLUPPERLOSTwo_Chosen() {
		if (mtsB_COLUPPERLOSTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLUPPERLOSTwo.GetComponent<Image>().color = offGray;
			noseIR_COLUPPERLOSTwo.GetComponent<Image>().color = offGray;
			mtsB_COLUPPERLOSTwo.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_COLLOWERLOSOne_Chosen() {
		if (mtsB_COLLOWERLOSOne.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLLOWERLOSOne.GetComponent<Image>().color = offGray;
			noseIR_COLLOWERLOSOne.GetComponent<Image>().color = offGray;
			mtsB_COLLOWERLOSOne.GetComponent<Image>().color = onBlue;
		}
	}
	
	public void mtsB_COLLOWERLOSTwo_Chosen() {
		if (mtsB_COLLOWERLOSTwo.GetComponent<Image>().color == onBlue) {
			return;
		}
		else {
			noseED_COLLOWERLOSTwo.GetComponent<Image>().color = offGray;
			noseIR_COLLOWERLOSTwo.GetComponent<Image>().color = offGray;
			mtsB_COLLOWERLOSTwo.GetComponent<Image>().color = onBlue;
		}
	}
	
	void Update() {
		if (hudIntOne_SATCOM.activeSelf == true) {
			currHUDActive = "HUD -> INT1 (SATCOM)";
		}
		else if (hudIntTwo_SATCOM.activeSelf == true) {
			currHUDActive = "HUD -> INT2 (SATCOM)";
		}
		else if (hudExtTwo.activeSelf == true) {
			currHUDActive = "HUD -> EXT2";
		}
		else if (hudTxOne.activeSelf == true) {
			currHUDActive = "HUD -> TX1";
		}
		else if (hudTxTwo.activeSelf == true) {
			currHUDActive = "HUD -> TX2";
		}
		else if (hudIntOne_COLUPPERLOS.activeSelf == true) {
			currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
		}
		else if (hudIntTwo_COLUPPERLOS.activeSelf == true) {
			currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
		}
		else if (hudIntOne_COLLOWERLOS.activeSelf == true) {
			currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
		}
		else if (hudIntTwo_COLLOWERLOS.activeSelf == true) {
			currHUDActive = "HUD -> INTw (COL LOWER LOS)";
		}
		
		if (dvrIntOne_SATCOM.activeSelf == true) {
			currDVRActive = "DVR -> INT1 (SATCOM)";
		}
		else if (dvrIntTwo_SATCOM.activeSelf == true) {
			currDVRActive = "DVR -> INT2 (SATCOM)";
		}
		else if (dvrExtTwo.activeSelf == true) {
			currDVRActive = "DVR -> EXT2";
		}
		else if (dvrTxOne.activeSelf == true) {
			currDVRActive = "DVR -> TX1";
		}
		else if (dvrTxTwo.activeSelf == true) {
			currDVRActive = "DVR -> TX2";
		}
		else if (dvrIntOne_COLUPPERLOS.activeSelf == true) {
			currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
		}
		else if (dvrIntTwo_COLUPPERLOS.activeSelf == true) {
			currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
		}
		else if (dvrIntOne_COLLOWERLOS.activeSelf == true) {
			currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
		}
		else if (dvrIntTwo_COLLOWERLOS.activeSelf == true) {
			currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
		}
	}
	
	public void intOne_SATCOM_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "DVR -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "DVR -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "DVR -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "DVR -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "DVR -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "DVR -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "DVR -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "DVR -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "DVR -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "DVR -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "DVR -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "DVR -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "DVR -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void intTwo_SATCOM_Wait() {
		intTwo_SATCOM.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "DVR -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "DVR -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "DVR -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "DVR -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "DVR -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "DVR -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "DVR -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "DVR -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "DVR -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "DVR -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "DVR -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "DVR -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "DVR -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void extTwo_Wait() {
		extTwo.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "DVR -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "DVR -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "DVR -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "DVR -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "DVR -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "DVR -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "DVR -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "DVR -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "DVR -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "DVR -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "DVR -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "DVR -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "DVR -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void txOne_Wait() {
		txOne.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void txTwo_Wait() {
		txTwo.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "HUD -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "HUD -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void intOne_COLUPPERLOS_Wait() {
		intOne_COLUPPERLOS.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "HUD -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "HUD -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void intTwo_COLUPPERLOS_Wait() {
		intTwo_COLUPPERLOS.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "HUD -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "HUD -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void intOne_COLLOWERLOS_Wait() {
		intOne_COLLOWERLOS.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "HUD -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "HUD -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL LOWER LOS)" && currDVRActive != "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL LOWER LOS)" && currDVRActive == "HUD -> INT2 (COL LOWER LOS)") {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void intTwo_COLLOWERLOS_Wait() {
		intTwo_COLLOWERLOS.GetComponent<Image>().color = waitingYellow;
		if (currHUDActive == "HUD -> INT1 (SATCOM)" && currDVRActive != "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (SATCOM)" && currDVRActive == "HUD -> INT1 (SATCOM)") {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (SATCOM)" && currDVRActive != "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (SATCOM)" && currDVRActive == "HUD -> INT2 (SATCOM)") {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_SATCOM.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> EXT2" && currDVRActive != "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> EXT2" && currDVRActive == "HUD -> EXT2") {
			extTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			extTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX1" && currDVRActive != "HUD -> TX1") {
			txOne.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX1" && currDVRActive == "HUD -> TX1") {
			txOne.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txOne.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> TX2" && currDVRActive != "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> TX2" && currDVRActive == "HUD -> TX2") {
			txTwo.GetComponent<Image>().color = dvrOrange;
		}
		else {
			txTwo.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)" && currDVRActive != "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL UPPER LOS)" && currDVRActive == "HUD -> INT1 (COL UPPER LOS)") {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)" && currDVRActive != "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT2 (COL UPPER LOS)" && currDVRActive == "HUD -> INT2 (COL UPPER LOS)") {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		}
		
		if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)" && currDVRActive != "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
		}
		else if (currHUDActive != "HUD -> INT1 (COL LOWER LOS)" && currDVRActive == "HUD -> INT1 (COL LOWER LOS)") {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
		}
		else {
			intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		}
	}
	
	public void hudClick() {
		if (intOne_SATCOM.GetComponent<Image>().color == waitingYellow) {
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(true);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> INT1 (SATCOM)";
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intTwo_SATCOM.GetComponent<Image>().color == waitingYellow) {
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(true);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> INT2 (SATCOM)";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (extTwo.GetComponent<Image>().color == waitingYellow) {
			extTwo.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(true);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> EXT2";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (txOne.GetComponent<Image>().color == waitingYellow) {
			txOne.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(true);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> TX1";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (txTwo.GetComponent<Image>().color == waitingYellow) {
			txTwo.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(true);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> TX2";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intOne_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(true);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intTwo_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(true);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intOne_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(true);
			hudIntTwo_COLLOWERLOS.SetActive(false);
			currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intTwo_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
			hudIntOne_SATCOM.SetActive(false);
			hudIntTwo_SATCOM.SetActive(false);
			hudExtTwo.SetActive(false);
			hudTxOne.SetActive(false);
			hudTxTwo.SetActive(false);
			hudIntOne_COLUPPERLOS.SetActive(false);
			hudIntTwo_COLUPPERLOS.SetActive(false);
			hudIntOne_COLLOWERLOS.SetActive(false);
			hudIntTwo_COLLOWERLOS.SetActive(true);
			currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == hudGreen) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == hudGreen) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == hudGreen) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == hudGreen) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == hudGreen) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == hudGreen) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == hudGreen) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
	}
	
	public void dvrClick() {
		if (intOne_SATCOM.GetComponent<Image>().color == waitingYellow) {
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(true);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> INT1 (SATCOM)";
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intTwo_SATCOM.GetComponent<Image>().color == waitingYellow) {
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(true);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> INT2 (SATCOM)";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (extTwo.GetComponent<Image>().color == waitingYellow) {
			extTwo.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(true);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> EXT2";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (txOne.GetComponent<Image>().color == waitingYellow) {
			txOne.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(true);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> TX1";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (txTwo.GetComponent<Image>().color == waitingYellow) {
			txTwo.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(true);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> TX2";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intOne_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(true);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> INT1 (COL UPPER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intTwo_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(true);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> INT2 (COL UPPER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intOne_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(true);
			dvrIntTwo_COLLOWERLOS.SetActive(false);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> INT1 (COL LOWER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
		else if (intTwo_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
			dvrIntOne_SATCOM.SetActive(false);
			dvrIntTwo_SATCOM.SetActive(false);
			dvrExtTwo.SetActive(false);
			dvrTxOne.SetActive(false);
			dvrTxTwo.SetActive(false);
			dvrIntOne_COLUPPERLOS.SetActive(false);
			dvrIntTwo_COLUPPERLOS.SetActive(false);
			dvrIntOne_COLLOWERLOS.SetActive(false);
			dvrIntTwo_COLLOWERLOS.SetActive(true);
			dvrHUD.SetActive(false);
			currHUDActive = "DVR -> INT2 (COL LOWER LOS)";
			if (intOne_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intOne_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (intTwo_SATCOM.GetComponent<Image>().color == dvrOrange) {
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
			}
			if (extTwo.GetComponent<Image>().color == dvrOrange) {
				extTwo.GetComponent<Image>().color = offGray;
			}
			if (txOne.GetComponent<Image>().color == dvrOrange) {
				txOne.GetComponent<Image>().color = offGray;
			}
			if (txTwo.GetComponent<Image>().color == dvrOrange) {
				txTwo.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intTwo_COLUPPERLOS.GetComponent<Image>().color == dvrOrange) {
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
			}
			if (intOne_COLLOWERLOS.GetComponent<Image>().color == dvrOrange) {
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
			}
		}
	}
}