﻿using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public GameObject cube;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        
        rb = this.cube.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Sphere")
            Destroy(other.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
        //rb.AddForce(0, 5, 0);
    }
}
