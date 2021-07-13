using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axeController : MonoBehaviour
{

    public string attack = "r";
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(attack))
        {
            Debug.Log("attack from axe");
            anim.SetTrigger("action");
        }

    }
}
