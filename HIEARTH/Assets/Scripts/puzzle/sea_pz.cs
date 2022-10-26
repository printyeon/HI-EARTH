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
                    img.sprite = sprite_img;
                }
                break;
            case 2:
                if (remove_trash.cnt >= (int)(34 * 0.4))
                {
                    img.sprite = sprite_img;
                }
                break;
            case 3:
                if (remove_trash.cnt >= (int)(34 * 0.5))
                {
                    img.sprite = sprite_img;
                }
                break;
            case 4:
                if (remove_trash.cnt >= (int)(34 * 0.6))
                {
                    img.sprite = sprite_img;
                }
                break;
            case 5:
                if (remove_trash.cnt >= (int)(34 * 0.7))
                {
                    img.sprite = sprite_img;
                }
                break;
            case 6:
                if (remove_trash.cnt >= (int)(34 * 0.8))
                {
                    img.sprite = sprite_img;
                }
                break;
            case 7:
                if (remove_trash.cnt >= (int)(34 * 0.9))
                {
                    img.sprite = sprite_img;
                }
                break;
            case 8:
                if (remove_trash.cnt == 34)
                {
                    img.sprite = sprite_img;
                }
                break;
        }
    }
}
