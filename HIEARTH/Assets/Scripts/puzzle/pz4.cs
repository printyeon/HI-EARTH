using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pz4 : MonoBehaviour
{
    Image img;
    public Sprite sprite_img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (player_p1.rock4)
        {
            img.sprite = sprite_img;
            pz1.pzNum++;
        }
    }
}
