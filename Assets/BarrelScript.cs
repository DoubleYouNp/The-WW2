using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public float rotationSpeed = 90f;

    public float minAngle = -15.0f;
    public float maxAngle = 6.0f;

    private float currentRotation = 0.0f;

    private void Update()
    {
        // Input for rotating the cannon up and down
        float rotateInput = 0.0f;

        // Check for key inputs to rotate the cannon
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rotateInput = 1.0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rotateInput = -1.0f;
        }

        // Calculate the new rotation angle
        float newRotation = currentRotation + rotateInput * rotationSpeed * Time.deltaTime;

        // Clamp the rotation angle within the limits
        newRotation = Mathf.Clamp(newRotation, minAngle, maxAngle);

        // Apply the rotation to the cannon
        transform.localRotation = Quaternion.Euler(newRotation, 0.0f, 0.0f);

        // Update the current rotation
        currentRotation = newRotation;

    }
}
