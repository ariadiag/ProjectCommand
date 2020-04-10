using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public virtual IEnumerator Start(){
		yield break;
	}
	
	public virtual IEnumerator Run(){
		yield break;
	}
	
	public virtual IEnumerator Pause(){
		yield break;
	}
	
	public virtual IEnumerator End(){
		yield break;
	}
}
