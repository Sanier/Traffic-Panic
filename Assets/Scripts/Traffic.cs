using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static System.Math;

public class Traffic : MonoBehaviour
{

    [SerializeField] float CarSpeed = 2f;

    public TrafficLight trafficLight;

    private NavMeshAgent navMeshAgent;
    

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    void FixedUpdate()
    {
        CarMovement();
    }

    public void CarMovement()
    {

        //if (trafficLight.flag == true)
        //{
            navMeshAgent.Move(Vector3.forward * CarSpeed); //car.MovePosition(transform.position + transform.forward * CarSpeed);    //smooth movement of the car
        //}

        //else
        //    navMeshAgent.isStopped = true; //car.drag = 2000;
    }
}