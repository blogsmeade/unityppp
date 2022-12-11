using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
    public Transform target;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (target.position.y > position.y)
        {
            position.y = target.position.y;
            transform.position = position;
        }
      
    }
}
