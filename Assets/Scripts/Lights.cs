using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lights: MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
            this.GetComponent<Lights>().enabled = true;
        if (Input.GetKey(KeyCode.G))
            this.GetComponent<Lights>().enabled = false;
    }
}