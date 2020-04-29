using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public bool isSitting;
    private Vector3 cameraPos;
    public GameObject pointToMoveTo;
    public bool movingToPoint;
    private float timetomovecounter = 1f;
    private float timetomove;
    public int speed;

    public int Boundary = 50;
    public int Camspeed = 10;

    private int screenWidth;
    private int screenHeight;
    // Start is called before the first frame update
    void Start()
    {
        isSitting = false;
        cameraPos = transform.position;
        Cursor.visible = false;
        screenHeight = Screen.height;
        screenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingToPoint)
        {
            timetomove -= Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, pointToMoveTo.transform.position, Time.deltaTime * speed);
            //transform.rotation = Vector3.Lerp(transform.rotation, pointToMoveTo.transform.rotation, Time.deltaTime);
            if (timetomove <= 0)
            {
                movingToPoint = false;
                // ThirdPersonCamera.instance.looking = true;

                isSitting = true;
            }
        }

        if(isSitting)
        {
            Vector3 rotation = transform.eulerAngles;

            if (Input.mousePosition.x > screenWidth - Boundary)
            {
                Boundary = 
                rotation.y += Camspeed * Time.deltaTime;
            }
            if (Input.mousePosition.x < 0 + Boundary)
            {
                rotation.y -= Camspeed * Time.deltaTime;
            }
            if (Input.mousePosition.y > screenHeight - Boundary)
            {
                rotation.x -= Camspeed * Time.deltaTime;
            }
            if (Input.mousePosition.y < 0 + Boundary)
            {
                rotation.x += Camspeed * Time.deltaTime;
            }
            transform.eulerAngles = rotation;

            if (Input.GetKey(KeyCode.Space))
            {
                isSitting = false;
                Cursor.visible = false;
                transform.position = new Vector3(transform.position.x, cameraPos.y, transform.position.z);
                ThirdPersonCamera.instance.looking = true;
                ThirdPersonMovement.instance.moving = true;
                
            }
        }


    }

    private void OnTriggerStay(Collider other)
    {


        if(other.tag == "monitor")
        {
        
            if(!isSitting && Input.GetKey(KeyCode.E))
            {
    
                ThirdPersonCamera.instance.looking = false;
                //cameraPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                ThirdPersonMovement.instance.moving = false;
                timetomove = timetomovecounter;
                movingToPoint = true;
                Cursor.visible = true;

                

            }

        }

    }

}
