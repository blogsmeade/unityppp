using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{ 
    public Vector3 moveDirection;
    
    void Start()
    {
       // Debug.Log(moveDirection);
       // Debug.Log(transform.position.x);
    }

    private void FixedUpdate()
    {
        //Debug.Log(Time.deltaTime + Time.deltaTime);
    }
}
