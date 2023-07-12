using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float speed = 30.0f; // Speed of the vehicle
    private float turnSpeed = 20; // Speed of the vehicle's turn
    private float horizontalInput; // Input for horizontal movement
    private float forwardInput; // Input for vertical movement   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            // Get the horizontal input
            horizontalInput = Input.GetAxis("Horizontal");
            // Get the vertical input
            forwardInput = Input.GetAxis("Vertical");

       // Move the vehicle forward
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
         // Turn the vehicle
         transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}