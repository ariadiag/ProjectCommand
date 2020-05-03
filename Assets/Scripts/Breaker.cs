		using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
	public bool lightsOn = false;
	private bool _triggered = false;
	public GameObject Light;
	
	void Update(){
		if (_triggered){
			if (Input.GetKeyDown(KeyCode.E)){
				GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
				FlipSwitch();
			}
		}
	}
	
	//Light Getters & Setters
    public bool AreLightsOn(){
		return lightsOn;
	}
	public bool FlipSwitch(){
		lightsOn = !lightsOn;
		Debug.Log("Lights Are Now" + lightsOn.ToString());
		return AreLightsOn();
	}
	
	//Unfortunate Business: Manual Trigger Detection...
    void OnTriggerEnter(Collider col){
		_triggered = true;
	} void OnTriggerExit(Collider col){
		_triggered = false;
	}
}
