using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Genel Canvas iþlemleri ve oyun içi ayarlarýn bulunduðu script

    public GameObject ScoreTxt;
    public PlayerManager pm;
    
    void Start()
    {
        //Kayalarýn birbiriyle çarpýþmamasý için Layer çarpýþmamasýný true yapýyoruz.
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Gems"), true);
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Rocks"), true);

        pm = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {

        ScoreTxt.GetComponent<Text>().text = pm.Score.ToString();
      
    }

}
