using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //�uanl�k sadece arka Planda oyuncunun skorunu de�i�tiren script

    public float Score;
    private void Awake()
    {
        Score = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Gems")
        {
            Destroy(collision.gameObject);
            Score++;

        }
    }
}
