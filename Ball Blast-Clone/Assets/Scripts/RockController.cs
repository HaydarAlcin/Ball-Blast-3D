using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public GameObject Rock;
    public float time;
    public PlayerManager pb;
    
    private void Start()
    {
        pb = FindObjectOfType<PlayerManager>();
    }

    void Update()
    {
        if (time>0)
        {
            time -= Time.deltaTime;
        }
        else
        {
          
            if (pb.Score >= 10)
            {
                Instantiate(Rock, transform.position, transform.rotation);
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = Random.Range(40, 65).ToString();
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = "?";
                time = 7f;
            }
            else
            {
                Instantiate(Rock, transform.position, transform.rotation);
                //Oluþacak kayanýn canýný 5 ile 25 arasýnda rastegle belirliyoruz
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = Random.Range(5, 25).ToString();
                time = 7f;
            }
            
        }
    }

    
}
