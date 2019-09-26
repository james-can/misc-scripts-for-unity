using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodySleep : MonoBehaviour
{
    //This is good for a ragdoll character
    void Start()
    {
        Rigidbody[] children = GetComponentsInChildren<Rigidbody>();
        //print(string.Format("Number of children: {0}", children.Length));
        foreach (var child in children)
        {
            child.Sleep();
        }
    }

    /*void Update()
    {
        
    }*/
}
