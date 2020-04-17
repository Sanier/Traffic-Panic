using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrafficLight : MonoBehaviour
{
    public Light redlight;
    public Light greenlight;

    public bool flag = false;

    private Touch touch;

    public float maxDis = 1f;
    

    // Start is called before the first frame update
    public void Start()
    {
        greenlight.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        TrafLight();
        print(flag);

    }

    public void TrafLight() //traffic light
    {
        if (greenlight.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //touch.phase == TouchPhase.Began
            {
                flag = false;
                greenlight.enabled = false;
                redlight.enabled = true;
                return;
            }
        }

        else if (redlight.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //Input.GetKeyDown(KeyCode.Space)
            {
                flag = true;
                greenlight.enabled = true;
                redlight.enabled = false;
                return;
            }
        }
    }
}