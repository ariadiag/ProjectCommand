using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;

public class CustomInkScript : MonoBehaviour
{
	//Basic Variables
	public TextAsset inkJSONAsset;
	private Story story;
	private int maxChoice; //holds the index of the last choice (always the silent choice)
	public List<string> s_tags; //story tags 
	//^^^MAKE PRIVATE
	
	//UI Variables
	public Button diaBox; //Dialogue Box : Switch this to a designated place in final
	private TextMeshProUGUI diaText;
	public Button buttonPrefab;
	
	//Timer Variables
	public Image timer;
	public static float default_time = 5f; //The default time for the timer
	private float set_time = default_time; //The time that is used in the timer
	private bool inChoiceTime = false;
	
	//Read Variables
	public float r_speed = 0.03f;
	private bool isReading = false;
	
    // Start is called before the first frame update
    void Start(){
        story = new Story(inkJSONAsset.text);
		diaText = diaBox.GetComponentInChildren<TextMeshProUGUI>();
    }
	
	//ALLOW KEYBOARD SELECTION! (fix later?)
	void FixedUpdate(){
		if (inChoiceTime){
			if(Input.GetKeyDown("1") && story.currentChoices.Count > 1){
				story.ChooseChoiceIndex(0);
				Talk();
			} else if (Input.GetKeyDown("2") && story.currentChoices.Count > 2){
				story.ChooseChoiceIndex(1);
				Talk();
			} else if(Input.GetKeyDown("3") && story.currentChoices.Count > 3){
				story.ChooseChoiceIndex(2);
				Talk();
			} else if (Input.GetKeyDown("4") && story.currentChoices.Count > 4){
				story.ChooseChoiceIndex(3);
				Talk();
			}
		}
	}
	
	public void Talk(){ //Main function for moving dialogue
		//RESET EVERYTHING
		ClearUI(); //Reset the choices if needed
		ClearTimer(); //Reset the timer and all the things
		
		//TODO: FindSpeaker(); read tags
		
		//SET THE NEXT LINE OF TEXT
		//diaText.text = GetNextLine();
			//Replace next line with a Read method so that choice and everything is disabled until the full text has been read through. For now, we can make it a typewriter, but eventually we want to make it last until the VA is done at least
		Read(GetNextLine());
		
		//SET THE CHOICES IF APPLICABLE
		if (!(story.currentChoices.Count <= 0)){
			inChoiceTime = true;
			maxChoice = story.currentChoices.Count-1;
			diaBox.interactable = false;
			DisplayChoices();
			SetTimerTime();
		}
		//RUN TIMER
		StartCoroutine(Countdown(set_time));
	}
	
	bool Read(string line){
		diaText.text = "";
		StartCoroutine(TypeWriter(line));
		diaBox.interactable = true;
		//while(isReading){
		//} 
		return true; 
	}
	
	void SetTimerTime(){
		//Setting the timer based on ink file!
		string _lastChoice = story.currentChoices[maxChoice].text;
		if (_lastChoice.Contains("<")){
			string numAsString = _lastChoice.Split('<','>')[1];
			set_time = float.Parse(numAsString);
		}
	}
	
	void DisplayChoices(){
		for (int i=0; i<story.currentChoices.Count -1; i++){ //Goes through choices and uses all but the last
			Choice choice = story.currentChoices[i];
			Button choiceButton = Instantiate(buttonPrefab) as Button;
			choiceButton.transform.SetParent(this.transform, false);
			
			TextMeshProUGUI choiceText = choiceButton.GetComponentInChildren<TextMeshProUGUI>();
			choiceText.text = choice.text;
			
			choiceButton.onClick.AddListener(delegate {
				OnClickChoiceButton(choice);
			});
		}
	}
	
	void OnClickChoiceButton(Choice choice){
		story.ChooseChoiceIndex(choice.index);
		Talk();
	}
	
	void ClearUI(){
		int childCount = this.transform.childCount;
		for (int i = childCount -1; i>=0; --i){
			GameObject.Destroy(this.transform.GetChild(i).gameObject);
		}
	}
	
	void ClearTimer(){
		StopAllCoroutines();
		timer.fillAmount = 1;
		set_time = default_time;
		inChoiceTime = false;
	}
	
	string GetNextLine(){
		string txt = "NO NEXT LINE!"; 
		if (story.canContinue){
			txt=story.Continue();
			s_tags = story.currentTags;
		} else {
			diaBox.interactable = false;
		} return txt; 
	}

    IEnumerator Countdown(float duration){
		while(isReading){ //Don't start timer until all text on screen!
			yield return new WaitForSeconds(0.1f);
		} 
		//Countdown! Do the thing!
		float timeLeft = duration;
		while (timeLeft>0){ //The Actual Timer
			timeLeft -= Time.deltaTime;
			if (inChoiceTime){ //don't show timer going down if not a choice!
				timer.fillAmount = timeLeft/duration;
			} yield return null;
		} 
		//If it's a choice, then automatically choose 3
		if (!(story.currentChoices.Count <= 0)){
			story.ChooseChoiceIndex(maxChoice);
		}
		//If not, just continue
		Talk();
	}

	IEnumerator TypeWriter(string line){
		isReading = true;
		foreach (char c in line){
			diaText.text += c;
			yield return new WaitForSeconds(r_speed);
		}
		isReading = false;
	}
}
