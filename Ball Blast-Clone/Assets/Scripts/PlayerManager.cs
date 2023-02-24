using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Þuanlýk sadece arka Planda oyuncunun skorunu deðiþtiren script

    public float Score;
    private void Awake()
    {
        Time.timeScale = 1;
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
