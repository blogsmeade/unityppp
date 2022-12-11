using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformKiller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Platform"))
        {
            Destroy(other.gameObject);
        }

    }
}
