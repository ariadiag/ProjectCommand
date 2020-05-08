		using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker : MonoBehaviour
{
	public bool lightsOn = true;
	
	public Animator anim;
	
	//Lights
	public GameObject Light;
	private GameObject playerCanvas;
	private Renderer playerScreen;
		public Material screenOn;
		public Material screenOff;
		public Material glassOn;
		public Material glassOff;
		private Material[] mats; //Temp holder for the player materials
		
	public GameObject bigScreen;
	
	//Values?
	float ambientValue = 0.9f;
	
	void Start(){
		anim = GetComponent<Animator>();
		playerScreen = GameObject.FindWithTag("PlayerScreen").GetComponent<Renderer>();
			mats = playerScreen.materials;
		playerCanvas = GameObject.FindWithTag("Powered");
		TurnOff();
	}
	
	//Light Getters & Setters
    public bool AreLightsOn(){
		return lightsOn;
	}
	
	public bool FlipSwitch(){
		FindObjectOfType<AudioManager>().Play("BreakerSwitch");
		if (lightsOn){
			//Turn Off All Light
			TurnOff();
		} else {
			//Turn On All Light
			TurnOn();
		}
		Debug.Log("Lights Are Now" + lightsOn.ToString());
		return AreLightsOn();
	}
	
	void TurnOff(){
		anim.Play("Turn Off", 0, 0f);
		lightsOn = false;
		
		//Turn Screen
		playerCanvas.SetActive(false); //potentially create a for loop to turn off all things with the tag Powered.
		mats[0] = screenOff;
		mats[1] = glassOff;
		playerScreen.materials = mats;
		
		//BigScreen
		bigScreen.SetActive(false);
		
		//Ambient Lighting
		RenderSettings.ambientIntensity = 0.5f;
	}
	
	void TurnOn(){
		anim.Play("Turn ON", 0, 0f);
		lightsOn = true;
			
		//Turn Screen
		playerCanvas.SetActive(true);
		mats[0] = screenOn;
		mats[1] = glassOn;
		playerScreen.materials = mats;
		
		//BigScreen
		bigScreen.SetActive(true);
		
		//Ambient Lighting
		RenderSettings.ambientIntensity = ambientValue;
	}
}
