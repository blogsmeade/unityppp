using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Testat_3_Jump : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 moveDirection;
    public Vector3 JumpForce;
    public Vector3 HighJumpForce;
    public Rigidbody2D rb;
    public bool wantJump;
    public bool left;
    public bool right;
    private SpriteRenderer mySpriteRenderer;
    private AudioSource jumpsound;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        jumpsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard currentKeyboard = Keyboard.current;

        if (currentKeyboard.dKey.isPressed && currentKeyboard.aKey.isPressed || currentKeyboard.rightArrowKey.isPressed && currentKeyboard.leftArrowKey.isPressed)
        {
            moveDirection = Vector3.zero;
            Move(moveDirection);
        }
        else if (currentKeyboard.dKey.isPressed || currentKeyboard.rightArrowKey.isPressed)
        {
            
            moveDirection = Vector3.right;
            Move(moveDirection);
            mySpriteRenderer.flipX = false;
             

        }
        else if(currentKeyboard.aKey.isPressed || currentKeyboard.leftArrowKey.isPressed )
        {
            
            moveDirection = Vector3.left;
            Move(moveDirection);
            mySpriteRenderer.flipX = true;
          
            
        }
        else
        {
            moveDirection = Vector3.zero;
            Move(moveDirection);
        }
      /*  if(currentKeyboard.spaceKey.wasPressedThisFrame)
        {
            wantJump = true;
        }*/
    }

    private void FixedUpdate()
    {
        //Vector3 velocity = moveDirection * moveSpeed;
        //rb.velocity = new Vector2(velocity.x, rb.velocity.y);
        if(wantJump)
        {
            wantJump = false;
            Jump();
        }
    }

    public void Move(Vector3 direction)
    {
        Vector3 velocity = moveDirection * moveSpeed;
        rb.velocity = new Vector2(velocity.x, rb.velocity.y);
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        Vector2 jumpForce = new Vector2(0f, JumpForce.y);
        rb.AddForce(jumpForce, ForceMode2D.Impulse);
        jumpsound.Play();
    }

    public void HighJump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        Vector2 jumpForce = new Vector2(0f, HighJumpForce.y);
        rb.AddForce(jumpForce, ForceMode2D.Impulse);
        jumpsound.Play();
    }
}
