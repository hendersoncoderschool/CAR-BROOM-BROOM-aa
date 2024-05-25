using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float maxSpeed;
    private Rigidbody rb;       
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            rb.AddForce(transform.forward  * speed * Time.deltaTime);
        }
         if(Input.GetKey("s")){
            rb.AddForce(transform.forward * -speed * 0.5f * Time.deltaTime);
        }
         if(Input.GetKey("a")){
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey("d")){
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

    }
}
