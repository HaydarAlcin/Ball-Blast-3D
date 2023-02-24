using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlUp : MonoBehaviour
{
    //�kinci Topun Olu�mas�n� Sa�layan Script
    public RockController rc;

    private void Start()
    {
        rc = FindObjectOfType<RockController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            collision.gameObject.transform.GetChild(3).gameObject.SetActive(true);
            rc.time = 3;
            Destroy(this.gameObject);
        }
    }



}
