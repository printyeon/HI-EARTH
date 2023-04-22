using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_key : MonoBehaviour
{
    public float speed;
    public float jumpspeed;

    Animator animator;
    Rigidbody2D rigid;

    Vector3 movement;
    bool isJumping = false;


    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
            Up();
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Go();
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            Stop();
        }
    }

    void FixedUpdate()
    {
        playermove();
        playerjump();
    }

    private void playerjump()
    {
        if (!isJumping)
            return;

        rigid.velocity = Vector2.zero;
        Vector2 jumpVelocity = new Vector2(0, jumpspeed);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);
        isJumping = false;
    }

    private void playermove()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }

        transform.position += moveVelocity * speed * Time.deltaTime;
    }
    public void Go()
    {
        animator.SetBool("iswalk", true);
    }
    public void Stop()
    {
        animator.SetBool("iswalk", false);
    }

    public void Up()
    {
        animator.SetBool("isjump", true);
    }
}

