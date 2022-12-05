using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float GameBoundSizeX = 5.6f;
    private float GameBoundSizeY = 10f;
    public Transform avatar;

    private void Update()
    {
        if (!avatar) return;
        var position = avatar.position;
        if(position.x>GameBoundSizeX /2)
        {
            position.x = -GameBoundSizeX / 2;
            avatar.position = position;
        }
        if (position.x < -GameBoundSizeX / 2)
        {
            position.x = GameBoundSizeX / 2;
            avatar.position = position;
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Vector3 CubeSize = Vector3.one;
        CubeSize.x = GameBoundSizeX;
        CubeSize.y = GameBoundSizeY;
        Gizmos.DrawWireCube(transform.position, CubeSize);
    }
    
}
