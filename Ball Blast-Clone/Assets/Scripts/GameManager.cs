using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Genel Canvas iþlemleri ve oyun içi ayarlarýn bulunduðu script

    public GameObject ScoreTxt;
    public PlayerManager pm;

    public bool checkRock;
    
    void Start()
    {
        //Kayalarýn birbiriyle çarpýþmamasý için Layer çarpýþmamasýný true yapýyoruz.
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
