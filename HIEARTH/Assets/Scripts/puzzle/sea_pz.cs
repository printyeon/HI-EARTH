using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class sea_pz : MonoBehaviour
{
    public int num;
    int p = 34;
    Image img;
    public Sprite sprite_img; 
    public static int[] pzNum2 = Enumerable.Repeat<int>(0, 8).ToArray<int>();
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        switch (num)
        {
            case 1:
                if (remove_trash.cnt >= (int)(34 * 0.3) || pzNum2[0] == 1)
                {
                    pzNum2[0] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 2:
                if (remove_trash.cnt >= (int)(34 * 0.4) || pzNum2[1] == 1)
                {
                    pzNum2[1] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 3:
                if (remove_trash.cnt >= (int)(34 * 0.5) || pzNum2[2] == 1)
                {
                    pzNum2[2] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 4:
                if (remove_trash.cnt >= (int)(34 * 0.6) || pzNum2[3] == 1)
                {
                    pzNum2[3] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 5:
                if (remove_trash.cnt >= (int)(34 * 0.7) || pzNum2[4] == 1)
                {
                    pzNum2[4] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 6:
                if (remove_trash.cnt >= (int)(34 * 0.8) || pzNum2[5] == 1)
                {
                    pzNum2[5] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 7:
                if (remove_trash.cnt >= (int)(34 * 0.9) || pzNum2[6] == 1)
                {
                    pzNum2[6] = 1;
                    img.sprite = sprite_img;
                }
                break;
            case 8:
                if (remove_trash.cnt == 34 || pzNum2[7] == 1)
                {
                    pzNum2[7] = 1;
                    img.sprite = sprite_img;
                }
                break;
        }
    }
}
