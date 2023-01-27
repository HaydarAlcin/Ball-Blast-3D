using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BulletMove : MonoBehaviour
{
    public ParticleSystem Explosion;

    //Kayalarda bulunan text de�i�kenini tutmak i�in olu�turdu�umuz ge�ici de�i�ken
    int health;
    

    //Mermi h�z�
    public float bulletSpeed;

    void Update()
    {
        //Mermilerin olu�tuktan sonra s�rekli olarak y ekseninde hareketi
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
            
            //Can azalmas�
            health = int.Parse(other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
            health -= 1;
            other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text = health.ToString();


            other.GetComponent<MeshRenderer>().material.color += new Color(-0.05f, 0, 0);

            if (other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text == "0")
            {
                Destroy(other.gameObject);
                Instantiate(Explosion, other.transform.position, Quaternion.identity);
            }
        }

        

        
    }
}
