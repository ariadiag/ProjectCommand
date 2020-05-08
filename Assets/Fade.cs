using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
	private Animator anim;
    // Start is called before the first frame update
    void Awake(){
		anim = GetComponent<Animator>();
		anim.Play("RevealOverlay", 0, 0f);
	}
	
	void Update(){
		
	}
}
