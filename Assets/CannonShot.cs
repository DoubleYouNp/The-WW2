using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShot : MonoBehaviour
{
    public GameObject particlePrefab; // Drag the particle prefab here in the inspector
    public Transform fireTransform; // Drag the transform of the fire position here in the inspector
    public float speed = 10f; // The speed of the particle

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Left mouse button
        {
            FireParticle();
        }
    }

    void FireParticle()
    {
        GameObject particle = Instantiate(particlePrefab, fireTransform.position, Quaternion.identity);
        Rigidbody rb = particle.AddComponent<Rigidbody>();
        rb.velocity = fireTransform.forward * speed;
    }
}
