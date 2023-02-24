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

    public GameManager gm;

    public bool oneMore;
    private void Start()
    {

        oneMore = true;
        pb = FindObjectOfType<PlayerManager>();
        gm = FindObjectOfType<GameManager>();
       
    }

    void Update()
    {
        if (time>0)
        {
            time -= Time.deltaTime;
        }
        else
        {
          
            if (pb.Score >= 10 && oneMore && gm.checkRock)
            {
                Instantiate(Rock, transform.position, transform.rotation);
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = "?";
                time = 4f;
                Rock.GetComponent<RocksMove>().health = 50;
                oneMore = false;
                gm.checkRock = false;

            }
            else
            {
                Instantiate(Rock, transform.position, transform.rotation);
                //Olu�acak kayan�n can�n� 5 ile 25 aras�nda rastegle belirliyoruz
                Rock.transform.GetChild(0).GetComponent<TextMesh>().text = Random.Range(10, 30).ToString();
                
                time = 4f;
            }
            
        }
    }

    
}
