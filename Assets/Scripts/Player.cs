using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool readNote = false;
	public Breaker breaker;
	public Camera camera;
	
	//Raycast Info
	
	
	void Start(){
		this.camera = GetComponent<Camera>();
	}
	
	
}
