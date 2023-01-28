using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    void Awake()
    {
        //Kayalarýn birbiriyle çarpýþmamasý için Layer çarpýþmamasýný true yapýyoruz.
        Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Rocks"), LayerMask.NameToLayer("Rocks"), true);

    }

}
