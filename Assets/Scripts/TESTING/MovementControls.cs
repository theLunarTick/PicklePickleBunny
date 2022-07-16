using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{

    public float speed;
    public float turnspeed;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        float turnMovement = Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }    
}
