using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class pz5 : MonoBehaviour
{
    Image img;
    public Sprite sprite_img;

    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (getTrash.get == 4 || pz1.pzNum[4] == 1) 
        {
            img.sprite = sprite_img;
            pz1.pzNum[4] = 1;
        } 
    }
}