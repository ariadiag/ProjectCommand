using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
	public bool lightsOn = false;
	
    void OnTriggerStay(Collider col){
		if (Input.GetKeyDown(KeyCode.E)){
			FlipSwitch();
		}
	}
	
	//Light Getters & Setters
    public bool AreLightsOn(){
		return lightsOn;
	}
	public bool FlipSwitch(){
		lightsOn = !lightsOn;
		return lightsOn;
	}
}
