using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksMove : MonoBehaviour
{
    Rigidbody rb;
    bool oneMore;
    public float speed;
    void Start()
    {
        oneMore = true;
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (oneMore)
        {
            //Local Eksene göre Kuvvet uyguluyor.
            rb.AddRelativeForce(0,speed,0);
            oneMore = false;
        }
    }
}
