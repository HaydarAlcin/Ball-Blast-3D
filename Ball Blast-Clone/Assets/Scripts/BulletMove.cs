using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour
{
    public ParticleSystem Explosion;
    public GameObject miniRock;

    //Kayalarda bulunan text deðiþkenini tutmak için oluþturduðumuz geçici deðiþken
    int health;
    

    //Mermi hýzý
    public float bulletSpeed;

    void Update()
    {
        //Mermilerin oluþtuktan sonra sürekli olarak y ekseninde hareketi
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);

        if (transform.position.y>10)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Rocks")
        {
            Destroy(this.gameObject);
            
            //Can azalmasý
            health = int.Parse(other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
            health -= 1;
            other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text = health.ToString();


            other.GetComponent<MeshRenderer>().material.color += new Color(-0.03f, 0.04f, 0.01f);

            if (other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text == "0")
            {
                
                Instantiate(Explosion, other.transform.position, Quaternion.identity);

                Destroy(other.gameObject);
                
                //Instantiate(miniRock, other.transform.GetChild(1).position, Quaternion.identity);
                //Instantiate(miniRock, other.transform.GetChild(2).position, Quaternion.identity);
                
                
            }
        }

        

        
    }
}
