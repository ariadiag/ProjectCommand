using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller; //physics controller attached to the player.
    public float movementSpeed = 12f; //player walk speed.
    public float gravity = -9.8f;
    //public float jumpHeight = 3f;
    public Transform groundCheck;
    public float groundDistance = 0.4f; //distance between the player and the ground.
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    public bool moving;
    public static ThirdPersonMovement instance;

    void Start()
    {
        moving = true;
        instance = this;
    }
    void Update()
    {
        if (moving) //check if player is able to move in any case.
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //checks all objects that have a ground surface for player to walk on.

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
            float leftToRight = Input.GetAxis("Horizontal"); //gets horizontal inputs (A and D).
            float forwardToBack = Input.GetAxis("Vertical"); //gets vertical inputs (W and S).

            Vector3 move = transform.right * leftToRight + transform.forward * forwardToBack;

            controller.Move(move * movementSpeed * Time.deltaTime); //controls the player to move left, right, forward, and back.
            /*if (Input.GetButtonDown("Jump") && isGrounded)
            {
                 velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
            */
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
