using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public bool readNote = false;
	public bool holdNote = false;
	public Breaker breaker;
	public Camera camera;
	
	//Raycast Info
	Ray ray;
	RaycastHit hit;
	
	//Temp
	public bool tutEnd = true;
	public TextMeshProUGUI hovertext;
	
	void Start(){
		this.camera = GetComponent<Camera>();
	}
	
	void Update(){
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit)){
			if (hit.collider.tag == "Breaker"){
				if (!tutEnd){
					hovertext.enabled = true;
				}
				
				if (Input.GetMouseButtonDown(0)){
					tutEnd = true;
					breaker.FlipSwitch();
				}
			} else if (hit.collider.tag == "Mover"){
				if (Input.GetMouseButtonDown(0)){
					string clipName = hit.collider.name + "_Shimy";
					Debug.Log(clipName);
					hit.collider.gameObject.GetComponent<Animator>().Play(clipName, 0,0f);
				}
			} else {
					hovertext.enabled = false;
			}
		}
	}
}
