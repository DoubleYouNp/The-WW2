using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemySoldierAI : MonoBehaviour
{
    public Transform[] coverSpots; // List of cover spots
    public float moveSpeed = 5f; // Movement speed of the AI
    private Transform targetCover; // Closest cover spot


    [SerializeField] float searchRadius = 10f;
    private NavMeshAgent navMeshAgent;
    [SerializeField] GameObject cover;
    public Transform unitsPotition; // gets the pos of all units
    private Rigidbody unitsRigidbody;
    [SerializeField] float enemyDistance;

    void Start()
    {
        coverSpots = GameObject.FindGameObjectsWithTag("Cover").Select(obj => obj.transform).ToArray();
        navMeshAgent = GetComponent<NavMeshAgent>();       
        unitsRigidbody = GetComponent<Rigidbody>();
        unitsPotition = GetComponent<Transform>();
        SpawnUnit();
    }


    void Update()
    {
        if (navMeshAgent.CompareTag("Cover"))
        {
            MoveTowardsCover();
        }
    }

    

    static void SpawnUnit()
    {

    }

    void MoveToTheObjective()
    {

    }

    public void MoveTowardsCover()
    {
        float minDistance = Mathf.Infinity;
        Transform closestCover = null;

        foreach (Transform coverSpot in coverSpots)
        {
            float distance = Vector3.Distance(transform.position, coverSpot.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestCover = coverSpot;
            }
        }

        targetCover = closestCover;
    }

    void ShootTheFirstEnemy()
    {

    }

    void VaultOver()
    {

    }

    void CapturObjective()
    {

    }
}
