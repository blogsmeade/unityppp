using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTestat_02 : MonoBehaviour
{
    public bool moveLeft;
    public bool moveRight;
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        moveLeft = Input.GetKey("a");
        moveRight = Input.GetKey("d");
    }

    private void FixedUpdate()
    {
        Vector3 a = Vector3.left * Time.fixedDeltaTime * moveSpeed;
        Vector3 d = Vector3.right * Time.fixedDeltaTime * moveSpeed;

        if (moveLeft == true && moveRight == true)
        {

        }
        else if (moveLeft == true)
        {
            transform.position += a;

        }
        else if (moveRight == true)
        {
            transform.position += d;
        }
        else
        {

        }
    }
}
