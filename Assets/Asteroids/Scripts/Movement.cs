using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20f; // Units to travel per second
    public float rotationSpeed = 360f; // Amount of rotation per second

    private Rigidbody2D rBody; // Reference to attached Rigidbody2D

    // Use this for initialization
    void Start()
    {
        // Get the reference to Rigidbody component here
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if A key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            // Rotate left
            // Not using Physics (Translating)
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }

        // Check if D is pressed
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate left         
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }

        // Check if W key is pressed
        if (Input.GetKey(KeyCode.W))
        {
            // Move in facing direction
            rBody.AddForce(transform.up * speed);
        }

        // Check if S key is pressed
        if (Input.GetKey(KeyCode.S))
        {
            // Move in facing direction
            rBody.AddForce(-transform.up * speed);
        }

    }
}
