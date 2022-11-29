using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRot : MonoBehaviour
{
    public Vector3 highJump;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Testat_3_Jump>(out var Testat_3_Jump))
        {
            if (other.attachedRigidbody.velocity.y > 0F) return;
            {
                Testat_3_Jump.Jump();
            }

        }

    }
}
