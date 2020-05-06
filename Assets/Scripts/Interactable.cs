using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactable : MonoBehaviour
{
    public Player player;
	public GameObject holder;
	public Button button;
	public TextMeshProUGUI exitText;
	bool pickedup;
	bool dropped;
	
	void Update(){
		if (pickedup){
			if (Input.GetKeyDown(KeyCode.Escape)){
				Drop();
			}
		}
		if (dropped){
			Destroy(this.gameObject);
		}
	}
	
	public void PickUp(){
		Debug.Log("TOUCHED NOTE!");
		button.interactable = false;
		this.transform.position = holder.transform.position;
		this.transform.parent = holder.transform;
		exitText.enabled = true;
		pickedup = true;
	}
	
	public void Drop(){
		Debug.Log("NOTE DROPPED!");
		player.readNote = true;
		dropped = true;
	}
}
