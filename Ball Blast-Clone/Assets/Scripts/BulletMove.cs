using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour
{

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
            //health = int.Parse(other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text);
            //health -= 1;
            //other.gameObject.transform.GetChild(0).GetComponent<TextMesh>().text = health.ToString();


            other.GetComponent<MeshRenderer>().material.color += new Color(-0.02f, 0.03f, 0.005f);

          
        }

        

        
    }
}
