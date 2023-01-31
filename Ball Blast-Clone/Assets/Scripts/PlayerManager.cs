using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float Score;
    private void Start()
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
