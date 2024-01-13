using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour

{
    //Braistorm
    //Camera move based on mouseMovement
    //mouse sensitivity
    //xmovement, ymovement
    //mousex, mousey


    //Creating variables
    public float mouseSensitivity = 300f;
    public float xRotation = 0f;
    public float yRotation = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Get mouse input
        //destination, mouse sensitivity, time
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Look up and down
        xRotation -= mouseY;

        //Avoid looking under your legs (unless you are very flexible)
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);

        //Look left and right
        yRotation += mouseX;

        //Apply the position irl
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
