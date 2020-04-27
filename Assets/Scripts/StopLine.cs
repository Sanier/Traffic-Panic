using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLine : MonoBehaviour
{
    public TrafficLight trl;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trl.flag == false)
        rb.MovePosition(Vector3.up);  

        else
            rb.MovePosition(Vector3.down);
    }
}
