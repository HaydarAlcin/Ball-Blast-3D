using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    
    public Transform RightWhl;
    public Transform LeftWhl;
    public Transform RightWhl2;
    public Transform LeftWhl2;

    public float speed;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();  
    }

    private void PlayerMove()
    {

        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        RotateWheels();
        
        
    }

    
    
    private void RotateWheels()
    {
        LeftWhl.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal") * -3));
        RightWhl.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal") * -3));
        RightWhl2.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal") * -3));
        LeftWhl2.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal") * -3));
    }
}
