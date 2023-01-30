using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksMove : MonoBehaviour
{

    Rigidbody rb;
    bool oneMore;
    public float speed;
    TextMesh txt;
    
    //Zemine çarptýðý sýrada uygulanacak olan kuvvet
    public float planeForce;

    void Awake()
    {
        oneMore = true;
        rb = GetComponent<Rigidbody>();
        txt = transform.GetChild(0).gameObject.GetComponent<TextMesh>();

    }

    
    void Update()
    {

        if (oneMore)
        {
            if (transform.position.x<0)
            {
                //Rock oluþtuðunda içerisinde bulunan Can göstergesini oyunda eðik görünmemesi için düzeltiyoruz.
                gameObject.transform.GetChild(0).transform.rotation= Quaternion.Euler(0,0,0);
                
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
                //Rock oluþtuðunda içerisinde bulunan Can göstergesini oyunda eðik görünmemesi için düzeltiyoruz.
                gameObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0,0);


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
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Column")
        {
            if (rb.velocity.x<0)
            {
                rb.AddForce(-planeForce * Time.deltaTime, 0, 0);
            }
            else if(rb.velocity.x > 0)
            {
                rb.AddForce(planeForce * Time.deltaTime, 0, 0);
            }
        }
    }

    
}
