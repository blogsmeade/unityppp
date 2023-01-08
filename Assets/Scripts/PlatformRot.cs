using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRot : MonoBehaviour
{
    private Animator animateRed;
    public Vector3 highJump;

    public void Start()
    {
        animateRed = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent<Testat_3_Jump>(out var Testat_3_Jump))
        {
            if (other.attachedRigidbody.velocity.y > 0F) return;
            {
                animateRed.SetBool("hit", true);
                Testat_3_Jump.HighJump();
            }

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        animateRed.SetBool("hit", false);
    }
}
