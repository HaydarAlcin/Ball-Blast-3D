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
            if (transform.position.x<0)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.Translate(2*Time.deltaTime,0,0);
                if (transform.position.x>=-2)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    //Local Eksene göre Kuvvet uyguluyor.
                    rb.AddRelativeForce(0, speed, 0);
                    oneMore = false;
                }
            }
            else
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.Translate(-2*Time.deltaTime, 0, 0);
                if (transform.position.x <= 2)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    //Local Eksene göre Kuvvet uyguluyor.
                    rb.AddRelativeForce(0, speed, 0);
                    oneMore = false;
                }
            }

            //Local Eksene göre Kuvvet uyguluyor.
            //rb.AddRelativeForce(0,speed,0);
            //oneMore = false;
        }
    }

    
}
