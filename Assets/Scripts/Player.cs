using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool readNote = false;
	public Breaker breaker;
	public Camera camera;
	
	//Raycast Info
	Ray ray;
	RaycastHit hit;
	
	void Start(){
		this.camera = GetComponent<Camera>();
	}
	
	void Update(){
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit)){
			if (Input.GetMouseButtonDown(0) && hit.collider.tag == "Breaker"){
				breaker.FlipSwitch();
			}
		}
	}
}
