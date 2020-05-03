using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speechtext : MonoBehaviour
{

    public Text speech;
    public string[] words;
    private int currText;
    private AudioManager source;
    // Start is called before the first frame update
    void Start()
    {
        source = FindObjectOfType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currText++;
            source.Play("TextClick");
        }


        
            speech.text = words[currText];
        



    }
}
