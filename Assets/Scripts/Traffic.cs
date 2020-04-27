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
    private NavMeshObstacle navMeshObstacle;
    

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshObstacle = GetComponent<NavMeshObstacle>();
    }


    void FixedUpdate()
    {
        CarMovement();
    }

    public void CarMovement()
    {
        navMeshAgent.Move(Vector3.forward * CarSpeed); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            Destroy(gameObject);
            print("Dead");
        }
    }
}