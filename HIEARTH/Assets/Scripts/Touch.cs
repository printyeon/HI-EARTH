using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public static bool istouch;
    // Start is called before the first frame update
    void Start()
    {
        istouch = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Untagged" || col.collider.tag == "rock")
        {
            istouch = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.tag == "Untagged" || col.collider.tag == "rock")
         {
            istouch = false;
        }

    }
}
