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
    bool isJumping = false, canJumping = true;
    float positonY;


    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {

 
            Debug.Log("loc2 : " + save.loc);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJumping)
            {
                canJumping = false;
                animator.SetBool("isjump", true);
                rigid.AddForce(Vector2.up * jumpspeed, ForceMode2D.Impulse);
            }
        }
        if (Touch.istouch)
        {
            animator.SetBool("isjump", false);
            canJumping = true;
        }
        else canJumping = false;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Go();
            playermove();
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || playerMove.dont_move)
        {
            Stop();
        }
    }
     void playermove()
    {
        if (!playerMove.dont_move)
        {
            Vector3 moveVelocity = Vector3.zero;

            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                moveVelocity = Vector3.left;
                if (this.transform.localScale.x > 0)
                {
                    this.transform.localScale = new Vector3(this.transform.localScale.x * (-1), this.transform.localScale.y, 1f);
                }
            }

            else if (Input.GetAxisRaw("Horizontal") > 0)
            {
                moveVelocity = Vector3.right;
                if (this.transform.localScale.x < 0)
                {
                    this.transform.localScale = new Vector3(this.transform.localScale.x * (-1), this.transform.localScale.y, 1f);
                }
            }
            transform.position += moveVelocity * speed * Time.deltaTime;
        }
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

