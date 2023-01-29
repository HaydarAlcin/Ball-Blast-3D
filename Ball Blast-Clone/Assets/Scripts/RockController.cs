using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public GameObject Rock;
    public float time;
    
    
    void Update()
    {
        if (time>0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            Instantiate(Rock, transform.position,transform.rotation);
            
            //Olu�acak kayan�n can�n� 5 ile 25 aras�nda rastegle belirliyoruz
            Rock.transform.GetChild(0).GetComponent<TextMesh>().text = Random.Range(5, 25).ToString();
            time = 7f;

            
        }
    }

    
}
