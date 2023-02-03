using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    //Sa� ve sol da bulunan RockCreater objelerinin kodlar�
    //Olu�turulan Kayalar�m�z� tuttu�umuz gameobject
    public GameObject Rock;

    //Ka� saniyede bir olu�turmaya karar verdi�imiz time de�i�kenimiz
    public float time;

    //PlayerManager scriptinden skoru kontrol etmek i�in olu�turdu�umuz de�i�kenimiz
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
                //Olu�acak kayan�n can�n� 5 ile 25 aras�nda rastegle belirliyoruz
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = Random.Range(10, 30).ToString();
                Rock.GetComponent<Rigidbody>().mass = Random.Range(0.09f,0.18f);
                time = 5f;
            }
            
        }
    }

    
}
