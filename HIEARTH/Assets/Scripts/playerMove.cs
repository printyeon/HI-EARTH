using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform player;
    public float Speed;
    public static bool right, left, iswalk;
    Animator animator;

    public static bool dont_move;
    // public static GameObject Player;
    Rigidbody2D rigid;

    public static bool asdf = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = player.GetComponent<Animator>();
        rigid = player.GetComponent<Rigidbody2D>();


    }
    // Update is called once per frame


    void Update()
    {
        if (iswalk) move();
    }
    void move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (left)
        {
            moveVelocity = Vector3.left;
            if (player.transform.localScale.x > 0)
            {
                player.transform.localScale = new Vector3(player.transform.localScale.x * (-1), player.transform.localScale.y, 1f);
            }
        }

        else if (right)
        {
            moveVelocity = Vector3.right;
            if (player.transform.localScale.x < 0)
            {
                player.transform.localScale = new Vector3(player.transform.localScale.x * (-1), player.transform.localScale.y, 1f);
            }
        }
        player.transform.position += moveVelocity * Speed * Time.deltaTime;


    }
    private void Awake()
    {
        //var obj = FindObjectsOfType<DontDestoryObject>();
        //if (obj.Length == 1)
        //{
        //  DontDestroyOnLoad(Player);
        //}
        //else
        //{
        // Destroy(gameObject);
        //}
        //}

    }
    public void Up()
    {
        right = false;
        animator.SetBool("iswalk", false);
        iswalk = false;
    }
    public void Dawn()
    {
        right = true;
        animator.SetBool("iswalk", true);
        iswalk = true;

    }
    public void BackUp()
    {
        left = false;
        animator.SetBool("iswalk", false);
        iswalk = false;
    }
    public void BackDown()
    {
        left = true;
        animator.SetBool("iswalk", true);
        iswalk = true;

    }
}


