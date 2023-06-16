using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class getTrash : MonoBehaviour
{ 
    public static int get;
    bool touch;
    int gett;

    //플레이어
    public GameObject player;

    //순간이동할 위치
    public static Vector3 position = new Vector3(12.2f, -0.2f, 0.0f);

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
        Debug.Log("Tgett : " + gett);
        Debug.Log("get : " + get);

        if (Trash.isTouch)
        { 
            if (touch && Trash.isClear)
            {
                Destroy(this.gameObject);
            }
        } 

        if (gett == 4)
        {
            Debug.Log("asdf");
            npc.istrashclear = 2;
            gett = 5;
            player.transform.position = position;
        }

    }

    private void OnMouseDown()
    {
        if (Trash.isClear == true)
        {
            touch = true;
            if (Trash.isTouch)
            {

                get++;
                gett += get;

            }
        }
        
    }
}
