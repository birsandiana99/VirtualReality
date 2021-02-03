using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{

    public Rigidbody projectile;

    public float angle = 15f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                FireAtPoint(hit.point);
            }
        }
    }

    private void FireAtPoint(Vector3 point)
    {
        projectile.transform.position = transform.position;
        Vector3 direction = point - transform.position;
        projectile.velocity = 3 * direction;
    }

}
