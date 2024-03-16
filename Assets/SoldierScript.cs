using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed in the Unity Editor
    public float rotationSpeed = 100f; // Adjust the rotation speed in the Unity Editor

    void Update()
    {
        // Get input from the arrow keys or WASD keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the GameObject based on the input and speed
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Rotate the camera
        float rotateHorizontal = Input.GetAxis("Mouse X");

        // Rotate the camera around the y-axis
        transform.Rotate(Vector3.up, rotateHorizontal * rotationSpeed * Time.deltaTime);
    }
}
