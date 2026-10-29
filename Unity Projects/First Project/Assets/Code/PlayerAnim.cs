using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = GetComponent<Rigidbody2D>().linearVelocity;
        vel.Normalize();
        float xInput = vel.x;
        float yInput = vel.y;
        //tell the animator component the values for x, and y
        GetComponent<Animator>().SetFloat("x", xInput);
        GetComponent<Animator>().SetFloat("y", yInput);
    }
}
