using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	private Image timerFill;
	public float setLength = 5f;
	float timeLeft;
	bool timesUp = false;
	
    // Start is called before the first frame update
    void Start()
    {
        timerFill = GetComponent<Image>();
		timeLeft = setLength;
    }

	
	public IEnumerator Countdown(){
		while (timeLeft>0){
			timeLeft -= Time.deltaTime;
			timerFill.fillAmount = timeLeft/setLength;yield return null;
		} Debug.Log("Finished!!!");
		
	}
}
