using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDirection : MonoBehaviour
{
    public float x, y, z;
    public bool enableMovement;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
     
       

       
    }

    void FixedUpdate ()
    {
        if (enableMovement == true)
        {
            transform.position = transform.position + new Vector3(x, y, z);
        };
    }
}
