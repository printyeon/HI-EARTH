using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class sea_pz : MonoBehaviour
{
    public int num;
    int p = 34;
    Image img;
    public Sprite sprite_img; 
    bool[] pzNum = new bool[8];
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        switch (num)
        {
            case 1:
                if (remove_trash.cnt >= (int)(34 * 0.3))
                {
                    pzNum[0] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 2:
                if (remove_trash.cnt >= (int)(34 * 0.4))
                {
                    pzNum[1] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 3:
                if (remove_trash.cnt >= (int)(34 * 0.5))
                {
                    pzNum[2] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 4:
                if (remove_trash.cnt >= (int)(34 * 0.6))
                {
                    pzNum[3] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 5:
                if (remove_trash.cnt >= (int)(34 * 0.7))
                {
                    pzNum[4] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 6:
                if (remove_trash.cnt >= (int)(34 * 0.8))
                {
                    pzNum[5] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 7:
                if (remove_trash.cnt >= (int)(34 * 0.9))
                {
                    pzNum[6] = true;
                    img.sprite = sprite_img;
                }
                break;
            case 8:
                if (remove_trash.cnt == 34)
                {
                    pzNum[7] = true;
                    img.sprite = sprite_img;
                }
                break;
        }
    }
}
