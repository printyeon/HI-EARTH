using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class pz5 : MonoBehaviour
{
    public GameObject pt;
    public int test = 0;
    Image img;
    public Sprite sprite_img, defalt_img;

    public GameObject t;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    
    void Start()
    {
        img = GetComponent<Image>();
        particle.Reset(pt, test);
        if (pz1.pzNum[4] != 1)
            getTrash.get = 0;
        if (getTrash.get != 4)
            pz1.pzNum[4] = 0;
    }

    void Update()
    {
        Invoke("trash", 0.1f);
        Debug.Log("pz1.pzNum[4] : " + pz1.pzNum[4]);
    }

    void trash()
    {
        if (getTrash.get == 4 || pz1.pzNum[4] == 1 || npc.npcNum[0] == 1)
        {
            img.sprite = sprite_img;
            if (t != null)
                t.SetActive(false);
            if (t1 != null)
                t1.SetActive(false);
            if (t2 != null)
                t2.SetActive(false);
            if (t3 != null)
                t3.SetActive(false);
            if (t4 != null)
                t4.SetActive(false);

            pz1.pzNum[4] = 1;
            if (test == 1)
            {
                Invoke("off", 0.6f);
            }
            test = particle.pParticle(pt, test);

        }
        else
        {
            img.sprite = defalt_img;
        }
    }
    void off()
    {

        pt.SetActive(false);
        test = 2;
    }
}