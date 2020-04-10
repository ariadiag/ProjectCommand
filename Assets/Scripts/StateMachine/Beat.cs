using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : InkReader
{
	public string knotname;
	public int popUpCount;
	public bool hasBlackOut;
	public int waitLength;
	
	public Breaker breaker;
	
	void Start(){
		SetStory(inkJSONAsset);
		//subKnots = GetStory();
	}
	
	public Beat(string knot, int pUC, bool hBO, int waitTime){
		this.knotname = knot;
		this.popUpCount = pUC;
		this.hasBlackOut = hBO;
		this.waitLength = waitTime;
	}
	
}
