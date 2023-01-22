using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
    }
}
