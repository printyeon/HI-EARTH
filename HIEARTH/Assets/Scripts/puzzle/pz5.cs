using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class pz5 : MonoBehaviour
{
    Image img;
    public Sprite sprite_img;

    public GameObject t;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (getTrash.get == 4 || pz1.pzNum[4] == 1) 
        {
            img.sprite = sprite_img;
            if (t != null)
                t.SetActive(false);
            if (t1!=null )
                t1.SetActive(false);
            if (t2 != null)
                t2.SetActive(false);
            if (t3 != null)
                t3.SetActive(false);
            if (t4 != null)
                t4.SetActive(false);
            
            pz1.pzNum[4] = 1;
        } 
    }
}