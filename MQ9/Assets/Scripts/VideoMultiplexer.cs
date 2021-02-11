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
	//public Button mtsB_SATCOMThree;
	public Button intOne_SATCOM;
	public Button intTwo_SATCOM;
	public Button extTwo_SATCOM;
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
	Color32 green = new Color32(1, 113, 0, 255);
	Color32 orange = new Color32(255, 107, 0, 255);
	Color32 blue = new Color32(3, 0, 255, 255);
	Color32 white = new Color32(255, 255, 255, 255);
	Color32 yellow = new Color32(216, 255, 0, 255);
	/* float noseED_SATCOMOne_Time;
	float noseED_SATCOMTwo_Time;
	float noseIR_SATCOMOne_Time;
	float noseIR_SATCOMTwo_Time;
	float mtsB_SATCOMOne_Time;
	float mtsB_SATCOMTwo_Time;
	float mtsB_SATCOMThree_Time;
	float noseED_CBandOne_Time;
	float noseED_CBandTwo_Time;
	float noseED_CBandThree_Time;
	float noseIR_CBandOne_Time;
	float noseIR_CBandTwo_Time;
	float noseIR_CBandThree_Time;
	float mtsB_CBandOne_Time;
	float mtsB_CBandTwo_Time;
	float mtsB_CBandThree_Time;
	float noseED_COLUPPERLOSOne_Time;
	float noseED_COLUPPERLOSTwo_Time;
	float noseIR_COLUPPERLOSOne_Time;
	float noseIR_COLUPPERLOSTwo_Time;
	float mtsB_COLUPPERLOSOne_Time;
	float mtsB_COLUPPERLOSTwo_Time;
	float noseED_COLLOWERLOSOne_Time;
	float noseED_COLLOWERLOSTwo_Time;
	float noseIR_COLLOWERLOSOne_Time;
	float noseIR_COLLOWERLOSTwo_Time;
	float mtsB_COLLOWERLOSOne_Time;
	float mtsB_COLLOWERLOSTwo_Time; */
    // Start is called before the first frame update
    void Start()
    {
        /* noseED_SATCOMOne_Time = 2.0f;
		noseED_SATCOMTwo_Time = 2.0f;
		noseIR_SATCOMOne_Time = 2.0f;
		noseIR_SATCOMTwo_Time = 2.0f;
		mtsB_SATCOMOne_Time = 2.0f;
		mtsB_SATCOMTwo_Time = 2.0f;
		mtsB_SATCOMThree_Time = 2.0f;
		noseED_CBandOne_Time = 2.0f;
		noseED_CBandTwo_Time = 2.0f;
		noseED_CBandThree_Time = 2.0f;
		noseIR_CBandOne_Time = 2.0f;
		noseIR_CBandTwo_Time = 2.0f;
		noseIR_CBandThree_Time = 2.0f;
		mtsB_CBandOne_Time = 2.0f;
		mtsB_CBandTwo_Time = 2.0f;
		mtsB_CBandThree_Time = 2.0f;
		noseED_COLUPPERLOSOne_Time = 2.0f;
		noseED_COLUPPERLOSTwo_Time = 2.0f;
		noseIR_COLUPPERLOSOne_Time = 2.0f;
		noseIR_COLUPPERLOSTwo_Time = 2.0f;
		mtsB_COLUPPERLOSOne_Time = 2.0f;
		mtsB_COLUPPERLOSTwo_Time = 2.0f;
		noseED_COLLOWERLOSOne_Time = 2.0f;
		noseED_COLLOWERLOSTwo_Time = 2.0f;
		noseIR_COLLOWERLOSOne_Time = 2.0f;
		noseIR_COLLOWERLOSTwo_Time = 2.0f;
		mtsB_COLLOWERLOSOne_Time = 2.0f;
		mtsB_COLLOWERLOSTwo_Time = 2.0f; */
    }
	
	public void noseED_SATCOMOne_Chosen() {
		if (noseED_SATCOMOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_SATCOMOne.GetComponent<Image>().color = blue;
			noseIR_SATCOMOne.GetComponent<Image>().color = white;
			mtsB_SATCOMOne.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_SATCOMTwo_Chosen() {
		if (noseED_SATCOMTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_SATCOMTwo.GetComponent<Image>().color = blue;
			noseIR_SATCOMTwo.GetComponent<Image>().color = white;
			mtsB_SATCOMTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_CBandOne_Chosen() {
		if (noseED_CBandOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandOne.GetComponent<Image>().color = blue;
			noseIR_CBandOne.GetComponent<Image>().color = white;
			mtsB_CBandOne.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_CBandTwo_Chosen() {
		if (noseED_CBandTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandTwo.GetComponent<Image>().color = blue;
			noseIR_CBandTwo.GetComponent<Image>().color = white;
			mtsB_CBandTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_CBandThree_Chosen() {
		if (noseED_CBandThree.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandThree.GetComponent<Image>().color = blue;
			noseIR_CBandThree.GetComponent<Image>().color = white;
			mtsB_CBandThree.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_COLUPPERLOSOne_Chosen() {
		if (noseED_COLUPPERLOSOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLUPPERLOSOne.GetComponent<Image>().color = blue;
			noseIR_COLUPPERLOSOne.GetComponent<Image>().color = white;
			mtsB_COLUPPERLOSOne.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_COLUPPERLOSTwo_Chosen() {
		if (noseED_COLUPPERLOSTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLUPPERLOSTwo.GetComponent<Image>().color = blue;
			noseIR_COLUPPERLOSTwo.GetComponent<Image>().color = white;
			mtsB_COLUPPERLOSTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_COLLOWERLOSOne_Chosen() {
		if (noseED_COLLOWERLOSOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLLOWERLOSOne.GetComponent<Image>().color = blue;
			noseIR_COLLOWERLOSOne.GetComponent<Image>().color = white;
			mtsB_COLLOWERLOSOne.GetComponent<Image>().color = white;
		}
	}
	
	public void noseED_COLLOWERLOSTwo_Chosen() {
		if (noseED_COLLOWERLOSTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLLOWERLOSTwo.GetComponent<Image>().color = blue;
			noseIR_COLLOWERLOSTwo.GetComponent<Image>().color = white;
			mtsB_COLLOWERLOSTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_SATCOMOne_Chosen() {
		if (noseIR_SATCOMOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_SATCOMOne.GetComponent<Image>().color = white;
			noseIR_SATCOMOne.GetComponent<Image>().color = blue;
			mtsB_SATCOMOne.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_SATCOMTwo_Chosen() {
		if (noseIR_SATCOMTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_SATCOMTwo.GetComponent<Image>().color = white;
			noseIR_SATCOMTwo.GetComponent<Image>().color = blue;
			mtsB_SATCOMTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_CBandTwo_Chosen() {
		if (noseIR_CBandTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandTwo.GetComponent<Image>().color = white;
			noseIR_CBandTwo.GetComponent<Image>().color = blue;
			mtsB_CBandTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_CBandThree_Chosen() {
		if (noseIR_CBandThree.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandThree.GetComponent<Image>().color = white;
			noseIR_CBandThree.GetComponent<Image>().color = blue;
			mtsB_CBandThree.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_COLUPPERLOSOne_Chosen() {
		if (noseIR_COLUPPERLOSOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLUPPERLOSOne.GetComponent<Image>().color = white;
			noseIR_COLUPPERLOSOne.GetComponent<Image>().color = blue;
			mtsB_COLUPPERLOSOne.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_COLUPPERLOSTwo_Chosen() {
		if (noseIR_COLUPPERLOSTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLUPPERLOSTwo.GetComponent<Image>().color = white;
			noseIR_COLUPPERLOSTwo.GetComponent<Image>().color = blue;
			mtsB_COLUPPERLOSTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void noseIR_COLLOWERLOSOne_Chosen() {
		if (noseIR_COLLOWERLOSOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLLOWERLOSOne.GetComponent<Image>().color = white;
			noseIR_COLLOWERLOSOne.GetComponent<Image>().color = blue;
			mtsB_COLLOWERLOSOne.GetComponent<Image>().color = white
		}
	}
	
	public void noseIR_COLLOWERLOSTwo_Chosen() {
		if (noseIR_COLLOWERLOSTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLLOWERLOSTwo.GetComponent<Image>().color = white;
			noseIR_COLLOWERLOSTwo.GetComponent<Image>().color = blue;
			mtsB_COLLOWERLOSTwo.GetComponent<Image>().color = white;
		}
	}
	
	public void mtsB_SATCOMOne_Chosen() {
		if (mtsB_SATCOMOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_SATCOMOne.GetComponent<Image>().color = white;
			noseIR_SATCOMOne.GetComponent<Image>().color = white;
			mtsB_SATCOMOne.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_SATCOMTwo_Chosen() {
		if (mtsB_SATCOMTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_SATCOMTwo.GetComponent<Image>().color = white;
			noseIR_SATCOMTwo.GetComponent<Image>().color = white;
			mtsB_SATCOMTwo.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_CBandOne_Chosen() {
		if (mtsB_CBandOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandOne.GetComponent<Image>().color = white;
			noseIR_CBandOne.GetComponent<Image>().color = white;
			mtsB_CBandOne.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_CBandTwo_Chosen() {
		if (mtsB_CBandTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandTwo.GetComponent<Image>().color = white;
			noseIR_CBandTwo.GetComponent<Image>().color = white;
			mtsB_CBandTwo.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_CBandThree_Chosen() {
		if (mtsB_CBandThree.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_CBandThree.GetComponent<Image>().color = white;
			noseIR_CBandThree.GetComponent<Image>().color = white;
			mtsB_CBandThree.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_COLUPPERLOSOne_Chosen() {
		if (mtsB_COLUPPERLOSOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLUPPERLOSOne.GetComponent<Image>().color = white;
			noseIR_COLUPPERLOSOne.GetComponent<Image>().color = white;
			mtsB_COLUPPERLOSOne.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_COLUPPERLOSTwo_Chosen() {
		if (mtsB_COLUPPERLOSTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLUPPERLOSTwo.GetComponent<Image>().color = white;
			noseIR_COLUPPERLOSTwo.GetComponent<Image>().color = white;
			mtsB_COLUPPERLOSTwo.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_COLLOWERLOSOne_Chosen() {
		if (mtsB_COLLOWERLOSOne.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLLOWERLOSOne.GetComponent<Image>().color = white;
			noseIR_COLLOWERLOSOne.GetComponent<Image>().color = white;
			mtsB_COLLOWERLOSOne.GetComponent<Image>().color = blue;
		}
	}
	
	public void mtsB_COLLOWERLOSTwo_Chosen() {
		if (mtsB_COLLOWERLOSTwo.GetComponent<Image>().color == blue) {
			break;
		}
		else {
			noseED_COLLOWERLOSTwo.GetComponent<Image>().color = white;
			noseIR_COLLOWERLOSTwo.GetComponent<Image>().color = white;
			mtsB_COLLOWERLOSTwo.GetComponent<Image>().color = blue;
		}
	}
}
