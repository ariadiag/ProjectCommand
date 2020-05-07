using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Sprite[] sprites;
	public SpriteRenderer[] renders;

    // Update is called once per frame
    void Update()
    {
		
    }
	
	public void Pop(){
		int rand_s = Random.Range(0,sprites.Length);
		int rand_r = Random.Range(0,renders.Length);
		
		renders[rand_r].sprite = sprites[rand_s];
	}
}
