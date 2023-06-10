using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class pz8 : MonoBehaviour
{ 
    Image img;
    public Sprite sprite_img;
    public GameObject t;
    public GameObject pt;
    public int test = 0;

    void Start()
    {

    img = GetComponent<Image>();
        particle.Reset(pt, test);
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
