using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Houses all of the functions seen in the H.264 Adanced Controls popup

public class H264AdvancedControls : MonoBehaviour
{
	public InputField streamPID;
	public InputField minQuantI;
	public InputField maxQuantI;
	public InputField minQuantP;
	public InputField maxQuantP;
	public InputField ptsOffset;
	public InputField gopSize;
	public InputField sliceMacroblocks;
	public InputField sliceBytes;
	public InputField macroblocks;
	public InputField intraRefreshPercent;
	public InputField pid;
	public InputField metaPID;
	public InputField smptePID;
	public InputField pcrPID;
	public InputField clk;
	public InputField pmtPID;
	public InputField tsPacketsUDP;
	public InputField timeToLive;
	public InputField tosOctet;
	public InputField localIPAddress;
	public InputField localSubnetMask;
	public InputField localGateway;
	public InputField remoteIPAddress;
	public InputField remotePort;
	static int minQuantIValue = 5;
	static int maxQuantIValue = 50;
	static int minQuantPValue = 5;
	static int maxQuantPValue = 50;
	static int intraRefreshPercentValue = 3;
	static int pidValue = 1001;
	static int metaPIDValue = 1011;
	static int smptePIDValue = 1012;
	static int pcrPIDValue = 1000;
	static int clkValue = 1776;
	static int pmtPIDValue = 32;
	static int tsPacketsUDPValue = 5;
	static int timeToLiveValue = 4;
	static int tosOctetValue = 5;
    // Start is called before the first frame update
    void Start()
    {
        streamPID.text = "1000";
		minQuantI.text = minQuantIValue.ToString();
		maxQuantI.text = maxQuantIValue.ToString();
		minQuantP.text = minQuantPValue.ToString();
		maxQuantP.text = maxQuantPValue.ToString();
		ptsOffset.text = "25000";
		gopSize.text = "150";
		sliceMacroblocks.text = "8195";
		sliceBytes.text = "1400";
		macroblocks.text = "360";
		intraRefreshPercent.text = intraRefreshPercentValue.ToString();
		pid.text = pidValue.ToString();
		metaPID.text = metaPIDValue.ToString();
		smptePID.text = smptePIDValue.ToString();
		pcrPID.text = pcrPIDValue.ToString();
		clk.text = clkValue.ToString();
		pmtPID.text = pmtPIDValue.ToString();
		tsPacketsUDP.text = tsPacketsUDPValue.ToString();
		timeToLive.text = timeToLiveValue.ToString();
		tosOctet.text = tosOctetValue.ToString();
		localIPAddress.text = "10.10.0.10";
		localSubnetMask.text = "255.0.0.0";
		localGateway.text = "10.10.0.1";
		remoteIPAddress.text = "10.10.0.11";
		remotePort.text = "8000";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void minQuantIIncrement() {
		minQuantIValue++;
		minQuantI.text = minQuantIValue.ToString();
	}
	
	public void minQuantIDecrement() {
		minQuantIValue--;
		if (minQuantIValue <= 0) {
			minQuantIValue = 0;
		}
		minQuantI.text = minQuantIValue.ToString();
	}
	
	public void maxQuantIIncrement() {
		maxQuantIValue++;
		maxQuantI.text = maxQuantIValue.ToString();
	}
	
	public void maxQuantIDecrement() {
		maxQuantIValue--;
		if (maxQuantIValue <= 0) {
			maxQuantIValue = 0;
		}
		maxQuantI.text = maxQuantIValue.ToString();
	}
	
	public void minQuantPIncrement() {
		minQuantPValue++;
		minQuantP.text = minQuantPValue.ToString();
	}
	
	public void minQuantPDecrement() {
		minQuantPValue--;
		if (minQuantPValue <= 0) {
			minQuantPValue = 0;
		}
		minQuantP.text = minQuantPValue.ToString();
	}
	
	public void maxQuantPIncrement() {
		maxQuantPValue++;
		maxQuantP.text = maxQuantPValue.ToString();
	}
	
	public void maxQuantPDecrement() {
		maxQuantPValue--;
		if (maxQuantPValue <= 0) {
			maxQuantPValue = 0;
		}
		maxQuantP.text = maxQuantPValue.ToString();
	}
	
	public void intraRefreshPercentIncrement() {
		intraRefreshPercentValue++;
		intraRefreshPercent.text = intraRefreshPercentValue.ToString();
	}
	
	public void intraRefreshPercentDecrement() {
		intraRefreshPercentValue--;
		if (intraRefreshPercentValue <= 0) {
			intraRefreshPercentValue = 0;
		}
		intraRefreshPercent.text = intraRefreshPercentValue.ToString();
	}
	
	public void pidIncrement() {
		pidValue++;
		pid.text = pidValue.ToString();
	}
	
	public void pidDecrement() {
		pidValue--;
		if (pidValue <= 0) {
			pidValue = 0;
		}
		pid.text = pidValue.ToString();
	}
	
	public void metaPIDIncrement() {
		metaPIDValue++;
		metaPID.text = metaPIDValue.ToString();
	}
	
	public void metaPIDDecrement() {
		metaPIDValue--;
		if (metaPIDValue <= 0) {
			metaPIDValue = 0;
		}
		metaPID.text = metaPIDValue.ToString();
	}
	
	public void smptePIDIncrement() {
		smptePIDValue++;
		smptePID.text = smptePIDValue.ToString();
	}
	
	public void smptePIDDecrement() {
		smptePIDValue--;
		if (smptePIDValue <= 0) {
			smptePIDValue = 0;
		}
		smptePID.text = smptePIDValue.ToString();
	}
	
	public void pcrPIDIncrement() {
		pcrPIDValue++;
		pcrPID.text = pcrPIDValue.ToString();
	}
	
	public void pcrPIDDecrement() {
		pcrPIDValue--;
		if (pcrPIDValue <= 0) {
			pcrPIDValue = 0;
		}
		pcrPID.text = pcrPIDValue.ToString();
	}
	
	public void clkIncrement() {
		clkValue++;
		clk.text = clkValue.ToString();
	}
	
	public void clkDecrement() {
		clkValue--;
		if (clkValue <= 0) {
			clkValue = 0;
		}
		clk.text = clkValue.ToString();
	}
	
	public void pmtPIDIncrement() {
		pmtPIDValue++;
		pmtPID.text = pmtPIDValue.ToString();
	}
	
	public void pmtPIDDecrement() {
		pmtPIDValue--;
		if (pmtPIDValue <= 0) {
			pmtPIDValue = 0;
		}
		pmtPID.text = pmtPIDValue.ToString();
	}
	
	public void tsPacketsUDPIncrement() {
		tsPacketsUDPValue++;
		tsPacketsUDP.text = tsPacketsUDPValue.ToString();
	}
	
	public void tsPacketsUDPDecrement() {
		tsPacketsUDPValue--;
		if (tsPacketsUDPValue <= 0) {
			tsPacketsUDPValue = 0;
		}
		tsPacketsUDP.text = tsPacketsUDPValue.ToString();
	}
	
	public void timeToLiveIncrement() {
		timeToLiveValue++;
		timeToLive.text = timeToLiveValue.ToString();
	}
	
	public void timeToLiveDecrement() {
		timeToLiveValue--;
		if (timeToLiveValue <= 0) {
			timeToLiveValue = 0;
		}
		timeToLive.text = timeToLiveValue.ToString();
	}
	
	public void tosOctetIncrement() {
		tosOctetValue++;
		tosOctet.text = tosOctetValue.ToString();
	}
	
	public void tosOctetDecrement() {
		tosOctetValue--;
		if (tosOctetValue <= 0) {
			tosOctetValue = 0;
		}
		tosOctet.text = tosOctetValue.ToString();
	}
}
