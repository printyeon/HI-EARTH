using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_key : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpspeed = 20.0f;

    Rigidbody2D rigid;

    Vector3 movement;
    bool isJumping = false;


    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        ;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
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

}

