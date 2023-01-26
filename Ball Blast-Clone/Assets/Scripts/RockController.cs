using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public GameObject Rock;
    public float time;
    
    
    void Update()
    {
        if (time>0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            Instantiate(Rock, transform.position,transform.rotation);
            time = 6f;

            
        }
    }

    
}
