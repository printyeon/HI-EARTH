using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove2 : MonoBehaviour
{
    public Transform player;
    public float Speed;
    public static bool right, left;
    Animator animator;
    Rigidbody2D rigid;

    public static bool dont_move;
    // Start is called before the first frame update
    void Start()
    {
        animator = player.GetComponent<Animator>();
        rigid = player.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (dont_move) { right = false; left = false; }
        if (right)
        {
            player.transform.position += Vector3.right * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(0.05f, 0.05f, 1f);
        }
        if (left)
        {
            player.transform.position += Vector3.left * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(-0.05f, 0.05f, 1f);
        }
    }

    public void Up()
    {
        right = false;
        animator.SetBool("iswalk", false);
    }
    public void Dawn()
    {
        right = true;
        animator.SetBool("iswalk", true);
    }
    public void BackUp()
    {
        left = false;
        animator.SetBool("iswalk", false);
    }
    public void BackDown()
    {
        left = true;
        animator.SetBool("iswalk", true);
    }
}
