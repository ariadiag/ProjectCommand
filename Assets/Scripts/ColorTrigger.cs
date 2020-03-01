using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    public bool isOn = false;
	
	public Material Off;
	public Material On;
	private Renderer cubeRen;
	
	void Start(){
		cubeRen = this.GetComponent<Renderer>();
		cubeRen.material = Off;
	}
	
	void Update(){
		if (isOn){
			cubeRen.material = On;
		} else {
			cubeRen.material = Off;
		}
	}
}
