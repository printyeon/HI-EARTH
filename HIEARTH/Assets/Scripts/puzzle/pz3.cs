using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pz3 : MonoBehaviour
{
    Image img;
    public Sprite sprite_img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (Click_rock.rock3)
        {
            img.sprite = sprite_img;
            pz1.pzNum++;
        }
    }
}
