using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksMove : MonoBehaviour
{
    //Kayalar�m�z�n hem hareketlerinin hem de oyun i�i durumlar�n�n kontrol edildi�i script

    //Kayalar yok olduktan sonra skorun artmas� i�in olu�an elmaslar
    public GameObject Gems;

    //Extra topun olu�mas� i�in oyuncunun yakalamas� gereken �zellik (Sadece ? kayalardan ��kar)
    public GameObject lvlUp;

    //Kayalar patlad�ktan sonra olu�an efekt
    public ParticleSystem Explosion;

    //Text Nesnesinin Rotate de�erini tutan de��ken
    Quaternion txtRotate;

    Rigidbody rb;
    bool oneMore;
    public float speed;
    
    
    //Zemine �arpt��� s�rada uygulanacak olan kuvvet
    public float planeForce;

    public float health;
    void Awake()
    {
        oneMore = true;
        rb = GetComponent<Rigidbody>();

        transform.GetChild(0).GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
        txtRotate = transform.GetChild(0).transform.rotation;
    }

    
    void Update()
    {
        if (transform.GetChild(0).transform.rotation!=txtRotate)
        {
            transform.GetChild(0).transform.rotation = txtRotate;
        }

        if (oneMore)
        {
            if (transform.position.x<0)
            {
                //Rock olu�tu�unda i�erisinde bulunan Can g�stergesini oyunda e�ik g�r�nmemesi i�in d�zeltiyoruz.
                //gameObject.transform.GetChild(0).transform.rotation= Quaternion.Euler(0,0,0);
                
                GetComponent<Rigidbody>().isKinematic = true;
                transform.Translate(4*Time.deltaTime,0,0);
                
                if (transform.position.x>=-2)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    
                    
                    //Local Eksene g�re Kuvvet uyguluyor.
                    rb.AddRelativeForce(0, speed, 0);
                    oneMore = false;
                }
            }
            else
            {
                //Rock olu�tu�unda i�erisinde bulunan Can g�stergesini oyunda e�ik g�r�nmemesi i�in d�zeltiyoruz.
                //gameObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(0,0,0);


                GetComponent<Rigidbody>().isKinematic = true;
                transform.Translate(-4*Time.deltaTime, 0, 0);
                
                if (transform.position.x <= 2)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    //Local Eksene g�re Kuvvet uyguluyor.
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
            if (transform.position.x>0)
            {
                rb.AddForce(-planeForce, 0, 0);
                
            }
            else if(transform.position.x < 0)
            {
                rb.AddForce(planeForce, 0, 0);
                
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            

            if (transform.GetChild(0).GetComponent<TextMesh>().text=="?")
            {
                health -= 1;

                if (health == 0)
                {
                    Destroy(this.gameObject);

                    Instantiate(Explosion, transform.position, Quaternion.identity);
                    Instantiate(lvlUp,transform.position,Quaternion.identity);

                    for (int i = 0; i < 6; i++)
                    {
                        Instantiate(Gems, transform.position, Quaternion.identity);
                        Gems.GetComponent<Rigidbody>().AddForce(Random.Range(-100f, 100f), 0, 0);


                    }
                }
            }

            else
            {
                health = int.Parse(transform.GetChild(0).GetComponent<TextMesh>().text);
                health -= 1;
                transform.GetChild(0).GetComponent<TextMesh>().text = health.ToString();

                if (health == 0)
                {
                    Destroy(this.gameObject);

                    Instantiate(Explosion, transform.position, Quaternion.identity);

                    for (int i = 0; i < 6; i++)
                    {
                        Instantiate(Gems, transform.position, Quaternion.identity);
                        Gems.GetComponent<Rigidbody>().AddForce(Random.Range(-100f, 100f), 0, 0);


                    }
                }
            }


            

           
        }
    }


}
