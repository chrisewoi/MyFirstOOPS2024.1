using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    Rigidbody rb;

    public float speed;
    public float rotationSpeed;
    public float lift;
    public float gravity = 9.81f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Move foward
        rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
    }
    // -MAFS-
    // Abs             - Makes number positive
    // Clamp           - Ensures a value is between two other values
    // Clamp01         - Clamps between 0 and 1

    // if N is between 0 - 1
    // 1 - N 
    // Invert a number 
    // 0.3 = 0.7
    // 0.1 = 0.9

    // Lerp            - Linear Interpolation
    //                        5  10
    //                         0.1
    //                          5.5
    // Sin/Cos         - waves
    // Dot product     - How much do vectors point in the same direction
    //                 - from 1 to -1  
    // Cross product   -

    void FixedUpdate()
    {
        //Input
        float input = Input.GetAxisRaw("Vertical");
        rb.AddTorque(transform.right * rotationSpeed * input * Time.deltaTime);
        


        //Lift
        float dot = Vector3.Dot(transform.forward, Vector3.up);
        dot = 1 - Mathf.Abs(dot);
        float liftResult = lift * dot;
        rb.AddForce(transform.up * liftResult * Time.deltaTime, ForceMode.Acceleration);

        //Forward
        //dot = Vector3.Dot(transform.forward, rb.velocity.normalized);
        //dot = Mathf.Abs(dot);
        rb.velocity = rb.velocity * dot;

        //dot = 1 - Mathf.Abs(dot);
        rb.velocity = transform.forward * rb.velocity.magnitude * dot;
        


        //Gravity
        rb.AddForce(Vector3.down * gravity * Time.deltaTime, ForceMode.Acceleration);
    }
}
