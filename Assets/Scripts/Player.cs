using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool readNote = false;
	public Camera camera;
	
	void Start(){
		this.camera = GetComponent<Camera>();
	}
}
