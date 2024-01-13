using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    //Get user input (ASWD || arrow keys)
    //VARIABLES
    //speed, gravity
    //velocity
    //free fall = 1/2g * t^2 

    //we can control player movement in 2 ways (generally) ; rigid body and character controller
    //we will use character controller here
    public float speed = 10f;
    public float gravity = -9.18f;

    Vector3 velocity;


    // Update is called once per frame
    void Update()
    {
    
        CharacterController controller = GetComponent<CharacterController>();

        //Get user input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //why do we do this?
        Vector3 move = transform.right * x + transform.forward * z;
        //right is on the x axis and forward is on the z axis since the main camera is facting z.

        //why do we do this?
        controller.Move(move * Time.deltaTime * speed);
        //the movement depends on each timeframe and the speed of the player that we created above.

        velocity.y -= gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            velocity.y += 2f * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
        
    }

    //if space is clicked
    //velocity.y - smth
}
