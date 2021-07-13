using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneProperties : MonoBehaviour
{
    public float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <=0 )
        {
            //delete stone 
            //eventually add particles and fun stuff
            Destroy(gameObject);
        }
    }
}
