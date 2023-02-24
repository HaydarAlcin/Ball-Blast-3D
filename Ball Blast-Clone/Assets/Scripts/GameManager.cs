using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Genel Canvas i�lemleri ve oyun i�i ayarlar�n bulundu�u script

    public GameObject ScoreTxt;
    public PlayerManager pm;

    public bool checkRock;
    
    void Start()
    {
        //Kayalar�n birbiriyle �arp��mamas� i�in Layer �arp��mamas�n� true yap�yoruz.
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Gems"), true);
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Rocks"), true);

        pm = FindObjectOfType<PlayerManager>();

        checkRock = true;
    }

    private void Update()
    {

        ScoreTxt.GetComponent<Text>().text = pm.Score.ToString();
      
    }

    public void TryAgainBtn()
    {
        SceneManager.LoadScene(0);
    }

}
