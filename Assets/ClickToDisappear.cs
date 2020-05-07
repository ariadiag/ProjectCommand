using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDisappear : MonoBehaviour
{
	private SpriteRenderer rend;
	
	void Start(){
		rend = GetComponent<SpriteRenderer>();
	}
	
    public void Disappear(){
		rend.sprite = null;
	}
}
