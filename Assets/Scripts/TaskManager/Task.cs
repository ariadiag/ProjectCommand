using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task :MonoBehaviour
{
	public TextMeshProUGUI description;
	public Animator anim;
	
	void Start(){
		this.description = GetComponentInChildren<TextMeshProUGUI>();
	}
	void OnEnable(){
		anim.Play("TaskReveal", 0, 0);
	}
	public void EndTask(){
		StartCoroutine(HideTask());
	}
	
	public void SetDesc(string d){
		this.description.text = d;
	} public string ReadDesc(){
		return this.description.text;
	}
	
	IEnumerator HideTask(){
		anim.Play("TaskHide", 0,0);
		yield return new WaitForSeconds(0.1f);
		Destroy(gameObject);
	}
}
