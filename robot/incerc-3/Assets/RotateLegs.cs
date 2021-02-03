using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLegs : MonoBehaviour
{

    private int i = 0;
    private bool front = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (front)
        {
            transform.Rotate(Vector3.right, -0.1f);
            i++;
            if (i == 300)
            {
                front = !front;
                i = 0;
            }
        }
        else
        {
            transform.Rotate(Vector3.right, -0.1f);
            i++;
            if (i == 300)
            {
                front = !front;
                i = 0;
            }
        }


    }
}

