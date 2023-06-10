using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class pz1 : MonoBehaviour
{
    public GameObject pt;
    public static int[] pzNum = Enumerable.Repeat<int>(0, 8).ToArray<int>();
    Image img;
    public Sprite sprite_img;
    public int test = 0;

    void Start()
    {
        img = GetComponent<Image>();
        particle.Reset(pt, test);
    }

    void Update()
    {
        Debug.Log("test : " + test);
        if (player_p1.rock1 || pzNum[0] == 1)
        {
            img.sprite = sprite_img;
            pzNum[0]=1;
          
           
        
            test = particle.pParticle(pt, test);
            if (test == 1)
            {
               
                Invoke("off", 0.6f);
            }
        }

    }
    void off()
    {

        pt.SetActive(false);
        test = 2;
    }
}
