using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public float Period;
    float TimeUntilNextSpawn;
    public GameObject Cars;

    UnityEngine.AI.NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        TimeUntilNextSpawn = Random.Range(0, Period);        
    }

    // Update is called once per frame
    void Update()
    {
        
        TimeUntilNextSpawn -= Time.deltaTime;
        if (TimeUntilNextSpawn <= 0.0f)
        {
            TimeUntilNextSpawn = Period;
            Instantiate(Cars, transform.position, transform.rotation);
        }
    }
}
