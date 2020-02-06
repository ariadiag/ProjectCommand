using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class InkExample : MonoBehaviour
{
	public TextAsset inkJSONAsset;
	private Story story;
	public Button buttonPrefab;
	
    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSONAsset.text);
		
		refresh();
    }

    void refresh(){
		clearUI();
		
		GameObject newGameObject = new GameObject("TextChunk");
		newGameObject.transform.SetParent(this.transform, false);
		
		Text newTextObject = newGameObject.AddComponent<Text>();
		newTextObject.fontSize = 24;
		newTextObject.text = getNextStoryBlock();
		newTextObject.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
		
		foreach (Choice choice in story.currentChoices){
			Button choiceButton = Instantiate(buttonPrefab) as Button;
			choiceButton.transform.SetParent(this.transform, false);
			
			Text choiceText = choiceButton.GetComponentInChildren<Text>();
			choiceText.text = choice.text;
			
			choiceButton.onClick.AddListener(delegate {
				OnClickChoiceButton(choice);
			});
		}
	}
	
	void OnClickChoiceButton(Choice choice){
		story.ChooseChoiceIndex(choice.index);
		refresh();
		//Remember to re enable button (box)
	}
	
	void clearUI(){
		int childCount = this.transform.childCount;
		for (int i = childCount -1; i >= 0; --i){
			GameObject.Destroy(this.transform.GetChild(i).gameObject);
		}
	}
	
	string getNextStoryBlock(){
		string text = "";
		if (story.canContinue){
			text=story.Continue();
		} return text;
	}
}
