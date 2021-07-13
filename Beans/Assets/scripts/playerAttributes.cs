using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttributes : MonoBehaviour
{
    public float health = 10;
    public string attack = "r";
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <=0)
        {
            //die
            Destroy(gameObject);
        }

        if(Input.GetKey(attack))
        {
            Debug.Log("attack");
        }
        
    }
}
