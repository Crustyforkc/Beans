using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

	public Rigidbody rb;
	public float forwardForce = 1000f;
	public float sidewaysForce = 800f;
	public float jumpHeight = 400f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
       if(Input.GetKey("d"))
       {
       		rb.AddForce(forwardForce * Time.deltaTime,0,0);
       		//go forward (z axis +)
       }

       if(Input.GetKey("a"))
       {
       		rb.AddForce(-forwardForce * Time.deltaTime,0,0);
       		//go backward (z axis -)
       }

       if(Input.GetKey("w"))
       {
       		rb.AddForce(0,0,forwardForce * Time.deltaTime);
       		//go right (x axis +)
       }

       if(Input.GetKey("s"))
       {
       		rb.AddForce(0,0, -forwardForce * Time.deltaTime);
       		//go left (x axis -)
       }

       if(Input.GetKey("space"))
       {
       		rb.AddForce(0,forwardForce * Time.deltaTime,0);
       		//go up (y axis +)
       		//should probably put something to check when space is it and then blacklist it otherwise you can fly

       }

    }
}
