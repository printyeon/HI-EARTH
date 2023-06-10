using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class pz6 : MonoBehaviour
{
    public GameObject pt;
    public int test = 0;
    Image img;
    public Sprite sprite_img;

    void Start()
    {
        img = GetComponent<Image>();
        particle.Reset(pt, test);
    }

    void Update()
    {
        if (player_p2.rock5 || pz1.pzNum[5] == 1)
        {
            img.sprite = sprite_img;
            pz1.pzNum[5] = 1;
            if (test == 1)
            {
                Invoke("off", 0.6f);
            }
            test = particle.pParticle(pt, test);

        }

    }
    void off()
    {

        pt.SetActive(false);
        test = 2;
    }
}