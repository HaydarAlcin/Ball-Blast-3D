using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    
    public GameObject Bullet;

    public float time;
    void Update()
    {
        if (time>0)
        {
            time -= Time.deltaTime;
        }
        else if(time<=0)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
            time = 0.1f;
        }
    }
}
