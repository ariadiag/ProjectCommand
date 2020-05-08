using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class cameramovement : MonoBehaviour
{
    public bool isSitting;
    private Vector3 cameraPos;
    public GameObject pointToMoveTo;
    public bool movingToPoint;
    private float timetomovecounter = 1f;
    private float timetomove;
    public int speed;

    public int RotationMaxUp;
    public int RotationMaxDown;
    public int RotationMaxLeft;
    public int RotationMaxRight;
    private bool canMove;

    public int Boundary = 50;
    public int Camspeed = 10;

    private int screenWidth;
    private int screenHeight;




    //public static void Vector3 GetInspectorRotation(Transform t);
    // Start is called before the first frame update
    void Start()
    {
        isSitting = true;
        cameraPos = transform.position;
        Cursor.visible = true;
        screenHeight = Screen.height;
        screenWidth = Screen.width;

        //isSitting = false;
        //cameraPos = transform.position;
        //Cursor.visible = false;
        //screenHeight = Screen.height;
        //screenWidth = Screen.width;
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

        Vector3 angle = transform.eulerAngles;
        float x = angle.x;
        float y = angle.y;

        if (Vector3.Dot(transform.up, Vector3.up) >= 0f)
        {
            if (angle.x >= 0f && angle.x <= 90f)
            {
                x = angle.x;
            }
            if (angle.x >= 270f && angle.x <= 360f)
            {
                x = angle.x - 360f;
            }
        }
        if (Vector3.Dot(transform.up, Vector3.up) < 0f)
        {
            if (angle.x >= 0f && angle.x <= 90f)
            {
                x = 180 - angle.x;
            }
            if (angle.x >= 270f && angle.x <= 360f)
            {
                x = 180 - angle.x;
            }
        }


        if (Vector3.Dot(transform.right, Vector3.right) >= 0f)
        {
            if (angle.y >= 0f && angle.y <= 90f)
            {
                y = angle.y;
            }
            if (angle.y >= 270f && angle.y <= 360f)
            {
                y = angle.y - 360f;
            }
        }
        if (Vector3.Dot(transform.right, Vector3.right) < 0f)
        {
            if (angle.y >= 0f && angle.y <= 90f)
            {
                y = 180 - angle.y;
            }
            if (angle.y >= 270f && angle.y <= 360f)
            {
                y = 180 - angle.y;
            }
        }

        //Debug.Log(angle + " :::: " + Mathf.Round(x) + " , " + Mathf.Round(y));

        if (isSitting)
        {
            Vector3 rotation = transform.eulerAngles;

            if (Input.mousePosition.x > screenWidth - Boundary && y < RotationMaxRight) //Wright Bros (whatever that means)
            {

                rotation.y += Camspeed * Time.deltaTime;
            }
            if (Input.mousePosition.x < 0 + Boundary && y > RotationMaxLeft) //left
            {

                rotation.y -= Camspeed * Time.deltaTime;
            }
            if (Input.mousePosition.y > screenHeight - Boundary && x > RotationMaxUp) // up
            {

                rotation.x -= Camspeed * Time.deltaTime;
            }
            if (Input.mousePosition.y < 0 + Boundary && x < RotationMaxDown) // down
            {
                rotation.x += Camspeed * Time.deltaTime;
            }
            transform.eulerAngles = rotation;




            /*if (Input.GetKey(KeyCode.Space))
            {
                isSitting = false;
                Cursor.visible = false;
                transform.position = new Vector3(transform.position.x, cameraPos.y, transform.position.z);
                ThirdPersonCamera.instance.looking = true;
                ThirdPersonMovement.instance.moving = true;
                
            }
            */
        }


    }

    /*private void OnTriggerStay(Collider other)
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
    */
}
