using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMP_TutManager : MonoBehaviour
{
    private State _currentState;
	
	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			StartCoroutine(_currentState.Pause());
		}
	}
}
