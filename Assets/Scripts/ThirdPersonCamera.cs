using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform player;
    float xRotation = 0f;
    public bool looking = true;
    public static ThirdPersonCamera instance;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        instance = this;
    }

    void Update()
    {
        if (looking)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            player.Rotate(Vector3.up * mouseX);
        }
    }
}
