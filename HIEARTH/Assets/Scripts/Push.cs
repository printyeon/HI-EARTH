using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "rock")
        {
            animator.SetBool("is push", true);

        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.tag == "rock")
        {
            animator.SetBool("is push", false);

        }
    }
}
