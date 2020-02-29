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
	public List<string> s_tags; //story tags 
	//^^^MAKE PRIVATE
	
	//UI Variables
	public Button diaBox; //Dialogue Box : Switch this to a designated place in final
	private TextMeshProUGUI diaText;
	public Button buttonPrefab;
	
	//Timer Variables
	public Image timer;
	private float default_time = 3f; //The default time for the timer
	public float set_time; //The time that is used in the timer
	
    // Start is called before the first frame update
    void Start(){
        story = new Story(inkJSONAsset.text);
		diaText = diaBox.GetComponentInChildren<TextMeshProUGUI>();
    }
	
	public void Talk(){ //Main function for moving dialogue
		clearUI(); //Reset the choices if needed
		clearTimer();
		diaBox.interactable = true;
		
		diaText.text = GetNextLine();
		if (!(story.currentChoices.Count <= 0)){
			diaBox.interactable = false;
			for (int i=0; i<story.currentChoices.Count -1; i++){ //Goes through choices and uses all but the last
				Choice choice = story.currentChoices[i];
				Button choiceButton = Instantiate(buttonPrefab) as Button;
				choiceButton.transform.SetParent(this.transform, false);
				
				TextMeshProUGUI choiceText = choiceButton.GetComponentInChildren<TextMeshProUGUI>();
				choiceText.text = choice.text;
				
				choiceButton.onClick.AddListener(delegate {
					OnClickChoiceButton(choice);
				});
				
				
				//If there is a timer tag, adjust the time.
				set_time = default_time;
				StartCoroutine(Countdown(set_time));
			}
		}
	}
	
	void OnClickChoiceButton(Choice choice){
		story.ChooseChoiceIndex(choice.index);
		Talk();
	}
	
	void clearUI(){
		int childCount = this.transform.childCount;
		for (int i = childCount -1; i>=0; --i){
			GameObject.Destroy(this.transform.GetChild(i).gameObject);
		}
	}
	
	void clearTimer(){
		StopAllCoroutines();
		timer.fillAmount = 1;
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
		float timeLeft = duration;
		while (timeLeft>0){
			timeLeft -= Time.deltaTime;
			timer.fillAmount = timeLeft/duration;
			yield return null;
		} 
		story.ChooseChoiceIndex(3);
		Talk();
	}
}
