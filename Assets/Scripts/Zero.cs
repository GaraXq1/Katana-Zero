using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zero : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    float Speed;
    bool OnGround = true;
    void Update()
    {
        move();
    }

    void move()
    {
        Speed = 0;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            sr.flipX = false;
            Speed = 0.5f;
            if(moveSpeed > 7)
            {
                Speed = 1;
            }
            else if (moveSpeed < 7)
            {
                moveSpeed += 0.02f;
            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
            sr.flipX = true;
            Speed = 0.5f;
            if (moveSpeed > 7)
            {
                Speed = 1;
            }
            else if (moveSpeed < 7)
            {
                moveSpeed += 0.02f;
            }
            
        }
        if (transform.position.y <= 0)
        {
            anim.SetBool("Jump", false);
            OnGround = true;
        }
        if (Input.GetKeyDown(KeyCode.W) && OnGround)
        {
            rb.velocity = new Vector2(0, jumpForce);
            anim.SetBool("Jump", true);
            OnGround = false;
        }

        if (Input.GetKeyUp(KeyCode.D)){moveSpeed = 5;}
        if (Input.GetKeyUp(KeyCode.A)){moveSpeed = 5;}
        anim.SetFloat("Speed", Speed);
    }


}
