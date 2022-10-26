using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform player;
    public float Speed=1.0f;
    public static bool right, left;
    Animator animator;

    public static bool dont_move;
    // public static GameObject Player;
    Rigidbody2D rigid;

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
            player.transform.localScale = new Vector3(0.1123015f, 0.1123015f, 1f);
        }
        if (left)
        {
            player.transform.position += Vector3.left * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(-0.1123015f, 0.1123015f, 1f);
        }

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


