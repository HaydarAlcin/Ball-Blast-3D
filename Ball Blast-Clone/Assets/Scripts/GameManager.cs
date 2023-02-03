using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Genel Canvas i�lemleri ve oyun i�i ayarlar�n bulundu�u script

    public GameObject ScoreTxt;
    public PlayerManager pm;
    
    void Start()
    {
        //Kayalar�n birbiriyle �arp��mamas� i�in Layer �arp��mamas�n� true yap�yoruz.
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Gems"), true);
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Rocks"), true);

        pm = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {

        ScoreTxt.GetComponent<Text>().text = pm.Score.ToString();
      
    }

}
