using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class pz1 : MonoBehaviour
{
    public static int[] pzNum = Enumerable.Repeat<int>(0, 8).ToArray<int>();
    Image img;
    public Sprite sprite_img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (player_p1.rock1 || pzNum[0] == 1)
        {
            img.sprite = sprite_img;
            pzNum[0]=1; 
        }
    }
}
 