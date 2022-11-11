using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public bool a;
    public bool b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true && b== true)
        {
            
        }
        else if (b==true)
        { 
            Debug.Log("b");
        }
        else if(a==true)
        {

            Debug.Log("a");

        }
            
    }
}
