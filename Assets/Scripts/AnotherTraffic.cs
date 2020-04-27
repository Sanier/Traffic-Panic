using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnotherTraffic : MonoBehaviour
{
    public float CarSpeed = 2f;
    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.Move(Vector3.right * CarSpeed);
    }
}
