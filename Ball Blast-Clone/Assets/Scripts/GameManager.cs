using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    void Awake()
    {
        //Kayalar�n birbiriyle �arp��mamas� i�in Layer �arp��mamas�n� true yap�yoruz.
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Rocks"), true);

    }

}