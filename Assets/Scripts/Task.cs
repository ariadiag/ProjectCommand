using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task :MonoBehaviour
{
	public TextMeshProUGUI description;
	public Animator anim;
	
	void Start(){
		this.description.text = "";
	}
	
	void OnEnable(){
		anim.Play("TaskReveal", 0, 0);
	}
	public void EndTask(){
		anim.Play("TaskHide", 0,0);
		Destroy(this);
	}
	
	public void SetDesc(string d){
		this.description.text = d;
	} public string ReadDesc(){
		return description.text;
	}
	
}
