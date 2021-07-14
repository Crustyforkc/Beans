using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupConrtoller : MonoBehaviour
{

    public Rigidbody rb;
    public BoxCollider coll;
    //for tracking hit boxes / collisions

    public Transform player, weapon, cam;
    //for tracking locations

    //for picking up and yeeting things
    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    public string dropKey = "g";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceToPlayer = player.position - transform.position;

        // a lot to unpack in this if statement first if not equipped and you are close enough to pick up AND "e" is pressed
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
        {
            PickUp();
        }

        //drop whats in hand
        if(equipped && Input.GetKey(dropKey))
        {
            Drop();
        }
    }

    private void PickUp()
    {

    }

    private void Drop()
    {

    }
}
