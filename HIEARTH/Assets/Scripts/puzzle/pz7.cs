using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class pz7 : MonoBehaviour
{ 
    Image img;
    public Sprite sprite_img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (getFruit.get_fruit || pz1.pzNum[6] == 1)
        {
            img.sprite = sprite_img;
            getFruit.get_fruit = true;
            getStick.Stick = true;
            pz1.pzNum[6] = 1;
        }
    }
}
 