using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource skrra;
    void Start()
    {
        skrra = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        skrra.Play();
    }
}
