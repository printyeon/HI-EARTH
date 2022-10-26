using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    public Transform player;
    public float jump;
    bool isjump = false;
    float thisy;
    Rigidbody2D rigid;
    Animator animator;

    void Start()
    {
        rigid = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isjump)
        {
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isjump = false;
        }
        if (Touch.istouch)
        {
            animator.SetBool("isjump", false);
            thisy = player.transform.position.y;
        }
        else
        {
            if (player.transform.position.y >= thisy + 0.5f)
                animator.SetBool("isjump", true);
        }
    }
    public void Up()
    {
        isjump = false;
    }
    public void Down()
    {
        if (Touch.istouch)
        {
            isjump = true;
        }
    }
}
