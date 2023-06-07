using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class pz8 : MonoBehaviour
{ 
    Image img;
    public Sprite sprite_img;
    public GameObject t;
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (Tabacoo.tabac || pz1.pzNum[7] == 1)
        {
            img.sprite = sprite_img;
            Tabacoo.tabac = true;
            pz1.pzNum[7] = 1;
            if (t != null)
                t.SetActive(false);
        }
    }
}
 