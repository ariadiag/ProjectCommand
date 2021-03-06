﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[System.Serializable]
public class MasterFlow : MonoBehaviour
{
	
	public TextAsset _maintJSONAsset;
	List<Beat> maintPhase;
	List<Beat> midPhase;
	List<Beat> goPhase;
	
	bool tutorial = true;
	bool mainten = false;
	
	public Player player;
	public InkReader reader;
	public Breaker breaker;
	//public Screen rscreen; Where pop ups happen...?
	public PopUp pops;
	
	public TaskManager tmanager;
	private bool running; //check if game is running
	bool phaseEnd = false;
	
    // Start is called before the first frame update
    void Start()
    {
        EstablishBeats();
		running = true;
		reader.SetStory(_maintJSONAsset);
    }
	
	void Update(){
	//TUTORIAL
		//Game Starts (Fade In)
		
		if (tutorial){
			//Player Reads Note
				//Turn Lights On
			if (!player.holdNote){
				Task t1 = tmanager.NewTask("Read the Note");
				player.holdNote = true;
			}
			if (player.readNote){
				tmanager.RemoveTask("Read the Note");
				Task t2 = tmanager.NewTask("Turn On the Lights");
				phaseEnd = true;
				player.readNote = false;
			} 
			if (phaseEnd && breaker.AreLightsOn()){
				tmanager.RemoveTask("Turn On the Lights");
				tutorial = false;
				mainten = true;
			}
			
		} else if (mainten){
			StartCoroutine(MaintenancePhase());
			mainten = false;
		}
		
		//if ink calledDispatch, then put timer up on big screen
	
	}
	
	IEnumerator MaintenancePhase(){
		yield return new WaitForSeconds(Random.Range(1.5f, 4.9f));
		foreach (Beat beat in maintPhase){
			reader.InitiateCall(beat.knotname);
			//PopUp(beat.popUpCount);
			while(!reader.storyOver){
				yield return new WaitForSeconds(0.1f);
			} 
			PopUp(beat.popUpCount);
			if (beat.hasBlackOut){
				breaker.FlipSwitch();
				while(!breaker.AreLightsOn()){
					yield return new WaitForSeconds(0.1f);
				}
			}
			yield return new WaitForSeconds(beat.waitLength);
		} DemoEnd();
	}
	
	void DemoEnd(){
		Debug.Log("Thank you for playing our demo!");
		SceneManager.LoadScene(2);
	}
	
	void PopUp(int num){
		for (int i = 0; i < num; i++){
			//PopUp a random
			pops.Pop();
		}
	}
	
	public void EstablishBeats(){
		maintPhase = new List<Beat>();
		midPhase = new List<Beat>();
		goPhase = new List<Beat>();
	//MAINTENANCE
		string[] knots = {"PhaseEvent2","PhaseEvent3","Fake1","PhaseEvent3.PE3A","PhaseEvent3.PE3B","PhaseEvent4.PE4A","PhaseEvent4.PE4B","PhaseEvent4.PE4C"};
		int[] popUps = {1,0,0,0,4,0,0,0};
		bool[] blackouts = {false,false,true, false,true,false,false,false};
		int[] waitlengths = {0,8,0,0,4,6,0,0};
		//Beat b = new Beat("PE2A", 5, true, 10);
		//Debug.Log(b.knotname);
		for (int i = 0; i < knots.Length; i++){
			maintPhase.Add(new Beat(knots[i],popUps[i],blackouts[i],waitlengths[i]));
		}
	//MID
	//GO
	}
	
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
	/*for each (beat in storyBeats){
		beat.Play(); //includes JSON and then 
		reader.
	}
	*/
	//MID PHASE
		//SetStory to MidPhase
		
		/*if (medicalDispatch){
			put timer on screens
		}*/
	
}
