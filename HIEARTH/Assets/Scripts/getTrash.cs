using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTrash : MonoBehaviour
{
    public static int get;
    bool touch;
    int gett;

    // Start is called before the first frame update
    void Start()
    {
        get = 0;
        gett = 0;
        touch = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Trash.isTouch)
        {
            if (touch)
            {
                Destroy(this.gameObject);
            }
        }

        if (gett == 4)
        {
            npc.istrashclear = 2;
            gett = 5;
        }

    }

    private void OnMouseDown()
    {
        touch = true;
        if (Trash.isTouch)
        {

            get++;
            gett += get;

        }
    }
}
