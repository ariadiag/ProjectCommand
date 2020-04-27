using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{
	public Player player;
	public bool isHolding = false;
	public GameObject holder;
	
	void Update(){
		if(isHolding){
			//GetComponent<Rigidbody>().velocity = Vector3.zero;
			//GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			this.transform.SetParent(holder.transform);
			this.transform.position = Vector3.zero;
			
			if (Input.GetKeyDown(KeyCode.Escape)){
				player.readNote = true;
				Destroy(gameObject);
			}
		}
	}
	
	public void SetHolding(){
		isHolding = true;		
	}



}
