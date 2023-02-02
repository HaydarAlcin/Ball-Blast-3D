using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public GameObject Rock;
    public float time;
    public PlayerManager pb;
    public RocksMove rm;

    public bool oneMore;
    private void Start()
    {

        oneMore = true;
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
          
            if (pb.Score >= 10 && oneMore)
            {
                Instantiate(Rock, transform.position, transform.rotation);
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = "?";
                time = 7f;
                Rock.GetComponent<RocksMove>().health = 60;
                oneMore = false;

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
