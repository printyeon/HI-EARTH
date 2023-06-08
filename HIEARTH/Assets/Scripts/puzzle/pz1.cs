using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class pz1 : MonoBehaviour
{
    public GameObject pt1;
    public static int[] pzNum = Enumerable.Repeat<int>(0, 8).ToArray<int>();
    Image img;
    public Sprite sprite_img;
    int test = 0;

    void Start()
    {
        img = GetComponent<Image>();
        pt1.SetActive(false);
    }

    void Update()
    {
        //Debug.Log()
        if (player_p1.rock1 || pzNum[0] == 1)
        {
            img.sprite = sprite_img;
            pzNum[0]=1;
            /*
            if (!pt1.activeSelf)
                test = 1;
            else
                test = 0;
            if (test == 1 )
            {
                off();
            }
            */
                
        }/*
        if(pt1.activeSelf)
        {
            Invoke("off", 0.6f);
        }
        */
    }

    public void off()
    {

        pt1.SetActive(true);
        //test = 2;
    }
}
 