using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    private Rigidbody rb;

    public float speed = 10f;
    public float gravity = 9.81f;
    public float lift = 10;
    public float rotationSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Forward
        rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
    }

    // Maths in games
    // Mathf.Abs                  - "Makes negative number positive"
    //                            - abs(50) = 50
    //                            - abs(-50) = 50
    // Clamp                      - Ensures a value is between two other values
    //                            -    5 - 10
    //                            -      5
    // Clamp01
    // 
    // Invert a number
    // if N is between 0 - 1
    // 1 - N
    // 1 - 0.75
    // 0.25
    // 
    //
    // Lerp                       - Linear Interpolation
    //                            -     5 - 10
    //                            -       0.1
    //                                =   5.5
    // Sin/Cos                    - waves
    //
    // Dot product                - How much do vectors point in he same direction
    //                              - from 1 to -1
    // Cross product - X
    //


    void FixedUpdate()
    {
        //Input
        float input = Input.GetAxisRaw("Vertical");
        rb.AddTorque(transform.right * rotationSpeed * input * Time.deltaTime);
        //Adds rotation


        //Lift
        float dot = Vector3.Dot(transform.forward, Vector3.up);
        dot = 1 - Mathf.Abs(dot);
        float liftResult = lift * dot;
        rb.AddForce(transform.up * lift * Time.deltaTime, ForceMode.Acceleration);

        //Gravity
        rb.AddForce(Vector3.down * gravity * Time.deltaTime, ForceMode.Acceleration);
    }
}
