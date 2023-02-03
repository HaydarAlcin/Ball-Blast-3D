using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    //Sað ve sol da bulunan RockCreater objelerinin kodlarý
    //Oluþturulan Kayalarýmýzý tuttuðumuz gameobject
    public GameObject Rock;

    //Kaç saniyede bir oluþturmaya karar verdiðimiz time deðiþkenimiz
    public float time;

    //PlayerManager scriptinden skoru kontrol etmek için oluþturduðumuz deðiþkenimiz
    public PlayerManager pb;

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
                time = 5f;
                Rock.GetComponent<RocksMove>().health = 50;
                oneMore = false;

            }
            else
            {
                Instantiate(Rock, transform.position, transform.rotation);
                //Oluþacak kayanýn canýný 5 ile 25 arasýnda rastegle belirliyoruz
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = Random.Range(10, 30).ToString();
                Rock.GetComponent<Rigidbody>().mass = Random.Range(0.09f,0.18f);
                time = 5f;
            }
            
        }
    }

    
}
