using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class MasterFlow : MonoBehaviour
{
	private State state;
	List<TextMeshProUGUI> stories;
	List<string> subKnots;
	
	public Player player;
	public InkReader reader;
	public Breaker breaker;
	//public Screen rscreen; Where pop ups happen...?
	
	public TaskManager tmanager;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	void Update(){
	//TUTORIAL
		//Game Starts (Fade In)
		//3 screens on; yours flickering - or arrow above
		//Player Reads Note -> Arrow point to Breaker
			//Turn Lights On
		if (player.readNote){
			Task t1 = tmanager.NewTask("Turn On the Lights");
			//AddArrow(breaker.transform.position);
			player.readNote = false;
		} if (breaker.AreLightsOn()){
			tmanager.RemoveTask("Turn On the Lights");
			reader.InitiateCall();
		}
		//Read 2nd Note -> Arrow point to supervisor's desk
			//Blinking file to open/download
	
	//MAINTENANCE PHASE
	  //Phase Event 2
		//Phone Call
			//reader.InitiateCall();
		//Pop Up on Right Screen
		//Continue Call
		//--Wait for some time--
	  //Phase Event 3
		//Phone Call
		//Player Finds Ship Information (Wait for Sec?)
		//Fake Call
		//Power Out
			//breaker.FlipSwitch();
		//When power back on, phone call
		//Highlight Medical Dispatch Button
		//Call Dispatch
	  //Phase Event 4
		//technically, call is continuing from phase 3
		//Screen Glitches & Pop Ups appear
		//Close 2; Lights Off
			//breaker.FlipSwitch();
		//When on, Phone Call
		//Right Screen Stuff; Wait for Time
		//Continue Call
		//Right Screen Stuff, Wait for time
		//Continue Call
	  //Phase Event 5
		//Right Screen stuff, Wait for time
		//Continue Call
		//Right Screen stuff, Wait for time
		//Continue Call
		
	//Temporary Stop
	//running = false;???
	
	//MID PHASE
		//SetStory to MidPhase
		
	}
}
