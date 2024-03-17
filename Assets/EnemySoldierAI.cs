using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoldierAI : MonoBehaviour
{
    public Transform unitsPotition; // gets the pos of all units
    private Rigidbody unitsRigidbody;
    [SerializeField] float enemyDistance;

    void Start()
    {
        unitsRigidbody = GetComponent<Rigidbody>();
        unitsPotition = GetComponent<Transform>();
        //SpawnUnit();
    }


    void Update()
    {
        if (unitsPotition.CompareTag("AllySoldier") <= enemyDistance)
        {

        }
    }
    
    
    //static void SpawnUnit()
    //{

    //}
    void MoveToTheObjective()
    {

    }
    void FindCover()
    {

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
