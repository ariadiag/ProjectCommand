using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task :MonoBehaviour
{
    public TextMeshProUGUI text;
	private Animator anim;
	
	void Start(){
		anim = GetComponent<Animator>();
	}
	
	void OnEnable(){
		//anim.Play("TaskReveal", 0, 0);
	} void OnDisable(){
		//anim.Play("TaskHide", 0,0);
	}
	
}
