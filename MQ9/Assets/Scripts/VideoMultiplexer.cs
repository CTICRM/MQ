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
		currHUDActive = "HUD -> INT1 (SATCOM)";
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
	
	public void intOne_SATCOM_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = waitingYellow;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void intTwo_SATCOM_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = waitingYellow;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void extTwo_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = waitingYellow;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void txOne_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = waitingYellow;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void txTwo_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = waitingYellow;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void intOne_COLUPPERLOS_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = waitingYellow;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void intTwo_COLUPPERLOS_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = waitingYellow;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void intOne_COLLOWERLOS_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = waitingYellow;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
	}
	
	public void intTwo_COLLOWERLOS_Wait() {
		intOne_SATCOM.GetComponent<Image>().color = offGray;
		intTwo_SATCOM.GetComponent<Image>().color = offGray;
		extTwo.GetComponent<Image>().color = offGray;
		txOne.GetComponent<Image>().color = offGray;
		txTwo.GetComponent<Image>().color = offGray;
		intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
		intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
		intTwo_COLLOWERLOS.GetComponent<Image>().color = waitingYellow;
	}
	
	/* public void dvrClick() {
		if (intOne_SATCOM.GetComponent<Image>().color == waitingYellow) {
			dvrIntOne_SATCOM.SetActive(true);
			intOne_SATCOM.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				return;
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (SATCOM)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intTwo_SATCOM.GetComponent<Image>().color == waitingYellow) {
			dvrIntTwo_SATCOM.SetActive(true);
			intTwo_SATCOM.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				return;
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (SATCOM)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (extTwo.GetComponent<Image>().color == waitingYellow) {
			dvrExtTwo.SetActive(true);
			extTwo.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				return;
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> EXT2";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (txOne.GetComponent<Image>().color == waitingYellow) {
			dvrTxOne.SetActive(true);
			txOne.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else if (currDVRActive == "DVR -> TX1") {
				return;
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX1";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (txTwo.GetComponent<Image>().color == waitingYellow) {
			dvrTxTwo.SetActive(true);
			txTwo.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else if (currDVRActive == "DVR -> TX2") {
				return;
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> TX2";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intOne_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			dvrIntOne_COLUPPERLOS.SetActive(true);
			intOne_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				return;
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL UPPER LOS)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intTwo_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			dvrIntTwo_COLUPPERLOS.SetActive(true);
			intTwo_COLUPPERLOS.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				return;
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL UPPER LOS)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intOne_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			dvrIntOne_COLLOWERLOS.SetActive(true);
			intOne_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				return;
			}
			else {
				dvrIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT1 (COL LOWER LOS)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intTwo_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			dvrIntTwo_COLLOWERLOS.SetActive(true);
			intTwo_COLLOWERLOS.GetComponent<Image>().color = dvrOrange;
			dvrHUD.SetActive(false);
			if (currDVRActive == "DVR -> INT1 (SATCOM)") {
				dvrIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (SATCOM)") {
				dvrIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> EXT2") {
				dvrExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> TX1") {
				dvrTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> TX2") {
				dvrTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL UPPER LOS)") {
				dvrIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT2 (COL UPPER LOS)") {
				dvrIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else if (currDVRActive == "DVR -> INT1 (COL LOWER LOS)") {
				dvrIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currDVRActive = "DVR -> INT2 (COL LOWER LOS)";
			}
			else {
				return;
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
	}
	
	public void hudClick() {
		if (intOne_SATCOM.GetComponent<Image>().color == waitingYellow) {
			hudIntOne_SATCOM.SetActive(true);
			intOne_SATCOM.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				return;
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (SATCOM)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intTwo_SATCOM.GetComponent<Image>().color == waitingYellow) {
			hudIntTwo_SATCOM.SetActive(true);
			intTwo_SATCOM.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				return;
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (SATCOM)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (extTwo.GetComponent<Image>().color == waitingYellow) {
			hudExtTwo.SetActive(true);
			extTwo.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				return;
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> EXT2";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (txOne.GetComponent<Image>().color == waitingYellow) {
			hudTxOne.SetActive(true);
			txOne.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else if (currHUDActive == "HUD -> TX1") {
				return;
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX1";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (txTwo.GetComponent<Image>().color == waitingYellow) {
			hudTxTwo.SetActive(true);
			txTwo.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else if (currHUDActive == "HUD -> TX2") {
				return;
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> TX2";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intOne_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			hudIntOne_COLUPPERLOS.SetActive(true);
			intOne_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				return;
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL UPPER LOS)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intTwo_COLUPPERLOS.GetComponent<Image>().color == waitingYellow) {
			hudIntTwo_COLUPPERLOS.SetActive(true);
			intTwo_COLUPPERLOS.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				return;
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL UPPER LOS)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intOne_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			hudIntOne_COLLOWERLOS.SetActive(true);
			intOne_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				return;
			}
			else {
				hudIntTwo_COLLOWERLOS.SetActive(false);
				intTwo_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT1 (COL LOWER LOS)";
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
		else if (intTwo_COLLOWERLOS.GetComponent<Image>().color == waitingYellow) {
			hudIntTwo_COLLOWERLOS.SetActive(true);
			intTwo_COLLOWERLOS.GetComponent<Image>().color = hudGreen;
			if (currHUDActive == "HUD -> INT1 (SATCOM)") {
				hudIntOne_SATCOM.SetActive(false);
				intOne_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (SATCOM)") {
				hudIntTwo_SATCOM.SetActive(false);
				intTwo_SATCOM.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> EXT2") {
				hudExtTwo.SetActive(false);
				extTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> TX1") {
				hudTxOne.SetActive(false);
				txOne.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> TX2") {
				hudTxTwo.SetActive(false);
				txTwo.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL UPPER LOS)") {
				hudIntOne_COLUPPERLOS.SetActive(false);
				intOne_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT2 (COL UPPER LOS)") {
				hudIntTwo_COLUPPERLOS.SetActive(false);
				intTwo_COLUPPERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else if (currHUDActive == "HUD -> INT1 (COL LOWER LOS)") {
				hudIntOne_COLLOWERLOS.SetActive(false);
				intOne_COLLOWERLOS.GetComponent<Image>().color = offGray;
				currHUDActive = "HUD -> INT2 (COL LOWER LOS)";
			}
			else {
				return;
			}
			Debug.Log(currHUDActive + ", " + currDVRActive);
		}
	} */
}