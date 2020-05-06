using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public Player player;
	public GameObject holder;
	public Button button;
	
	public void PickUp(){
		Debug.Log("TOUCHED NOTE!");
		player.readNote = true;
		button.interactable = false;
		this.transform.position = holder.transform.position;
		this.transform.parent = holder.transform;
	}
	
	public void Drop(){
		
	}
}
