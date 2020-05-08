using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roster : MonoBehaviour
{
	private GameObject currentBio;
	public GameObject R_Bio;
	public GameObject A_Bio;
	public GameObject H_Bio;
	public GameObject S_Bio;
    
	public void Show(string RAHS){
		Reset();
		switch (RAHS){
			case "r":
				currentBio = R_Bio;
				currentBio.SetActive(true);
				break;
			case "a":
				currentBio = A_Bio;
				currentBio.SetActive(true);
				break;
			case "h":
				currentBio = H_Bio;
				currentBio.SetActive(true);
				break;
			case "s":
				currentBio = S_Bio;
				currentBio.SetActive(true);
				break;
			default: break;
			return;
		}
	}
	
	void Reset(){
		if (currentBio !=null){
			currentBio.SetActive(false);
		}
	}
}
