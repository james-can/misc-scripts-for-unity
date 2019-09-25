using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodySleep : MonoBehaviour
{
    List<Rigidbody> children;
    // Start is called before the first frame update
    void Start()
    {
        

        Rigidbody[] childArray = GetComponentsInChildren<Rigidbody>();
        children = new List<Rigidbody>();
        children.AddRange(childArray);
        
        foreach(var child in children)
        {
            child.Sleep();
        }

        //rb = GetComponent<Rigidbody>();
        //rb.Sleep();
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
