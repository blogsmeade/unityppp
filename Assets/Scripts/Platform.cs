using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Rigidbody2D rb;
    private Animator animate;
    void Start()
    {
        animate = GetComponent<Animator>();
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
      {
          if (collision.gameObject.TryGetComponent<Testat_3_Jump>(out var Testat_3_Jump))
          {
              Testat_3_Jump.Jump();
          }
          else
          {
              Debug.Log("Somethin else collided with me!");
          }
      }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.TryGetComponent<Testat_3_Jump>(out var Testat_3_Jump))
        {
            if (other.attachedRigidbody.velocity.y > 0F) return;
            {
                animate.SetBool("hit", true);
                Testat_3_Jump.Jump();
               
            }
            
                
            }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        animate.SetBool("hit", false);
    }
}
