using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed in the Unity Editor
    public float rotationSpeed = 120f; // Adjust the rotation speed in the Unity Editor
    public GameObject[] leftWheels;
    public GameObject[] rightWheels;

    public GameObject[] leftTrucks;
    public GameObject[] rightTrucks;

    public float wheelRotationSpeed = 200f;

    private Rigidbody rb;
    private float moveInput;
    private float rotationInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveInput = Input.GetAxis("Vertical");
        rotationInput = Input.GetAxis("Horizontal");

        RotateWheels(moveInput, rotationInput);
    }
    private void FixedUpdate()
    {
        MoveTankObj(moveInput);
        RotateTankObj(rotationInput);
    }
    void MoveTankObj(float input)
    {
        Vector3 moveDirection = transform.forward * input *moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + moveDirection);
    }
    void RotateTankObj(float input)
    {
        float rotation = input * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, rotation, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
    void RotateWheels(float moveInput, float rotationInput)
    {
        float wheelRotation  = moveInput * wheelRotationSpeed * Time.deltaTime;

        foreach (GameObject wheel in leftWheels)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(wheelRotation - rotationInput * wheelRotationSpeed * Time.deltaTime, 0f, 0f);

            }
        }
        foreach (GameObject wheel in rightWheels)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(wheelRotation + rotationInput * wheelRotationSpeed * Time.deltaTime, 0f, 0f);

            }
        }
    }
}
