using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class pz7 : MonoBehaviour
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
        if (getFruit.get_fruit || pz1.pzNum[6] == 1)
        {
            img.sprite = sprite_img;
            getFruit.get_fruit = true;
            getStick.Stick = true;
            pz1.pzNum[6] = 1;
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
