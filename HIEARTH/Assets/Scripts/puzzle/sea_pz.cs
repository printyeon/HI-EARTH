using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class sea_pz : MonoBehaviour
{

    public GameObject[] pt = new GameObject[8];
    public int[] test = new int[8];

    public int num;
    int p = 34;
    Image img;
    public Sprite sprite_img; 
    public static int[] pzNum2 = Enumerable.Repeat<int>(0, 8).ToArray<int>();
    void Start()
    {
        img = GetComponent<Image>();
         test = Enumerable.Repeat<int>(0, 8).ToArray<int>();

        for(int i =0; i<pt.Length; i++)
        {
            pt[i].SetActive(false);
        }
  
            for (int i = 4; i < 8; i++)
            {
                npc.npcNum[i] = 0;
            }
        
   
        

    }

    void Update()
    {
        switch (num)
        {
            case 1:
                if (remove_trash.cnt >= (int)(34 * 0.3) || pzNum2[0] == 1)
                {
                    pzNum2[0] = 1;
                    img.sprite = sprite_img;


                    if (test[0] == 1)
                    {
                        StartCoroutine(off(pt[0], 0));
                    }
                  test[0] = particle.pParticle(pt[0], test[0]);
                }
                break;
            case 2:
                if (remove_trash.cnt >= (int)(34 * 0.4) || pzNum2[1] == 1)
                {
                    pzNum2[1] = 1;
                    img.sprite = sprite_img;

                    if (test[1] == 1)
                    {
                        StartCoroutine(off(pt[1], 1));
                    }
                    test[1] = particle.pParticle(pt[1], test[1]);
                }
                break;
            case 3:
                if (remove_trash.cnt >= (int)(33 * 0.5) || pzNum2[2] == 1)
                {
                    pzNum2[2] = 1;
                    img.sprite = sprite_img;

                    if (test[2] == 1)
                    {
                        StartCoroutine(off(pt[2], 2));
                    }
                    test[2] = particle.pParticle(pt[2], test[2]);
                }
                break;
            case 4:
                if (remove_trash.cnt >= (int)(33 * 0.6) || pzNum2[3] == 1)
                {
                    pzNum2[3] = 1;
                    img.sprite = sprite_img;

                    if (test[3] == 1)
                    {
                        StartCoroutine(off(pt[3], 3));
                    }
                   test[3] =  particle.pParticle(pt[3], test[3]);
                }
                break;
            case 5:
                if (remove_trash.cnt >= (int)(33 * 0.7) || pzNum2[4] == 1)
                {
                    pzNum2[4] = 1;
                    img.sprite = sprite_img;

                    if (test[4] == 1)
                    {
                        StartCoroutine(off(pt[4], 4));
                    }
                    test[4] =  particle.pParticle(pt[4], test[4]);
                }
                break;
            case 6:
                if (remove_trash.cnt >= (int)(33 * 0.8) || pzNum2[5] == 1)
                {
                    pzNum2[5] = 1;
                    img.sprite = sprite_img;

                    if (test[5] == 1)
                    {
                        StartCoroutine(off(pt[5], 5));
                    }
                    test[5] =  particle.pParticle(pt[5], test[5]);
                }
                break;
            case 7:
                if (remove_trash.cnt >= (int)(33 * 0.9) || pzNum2[6] == 1)
                {
                    pzNum2[6] = 1;
                    img.sprite = sprite_img;

                    if (test[6] == 1)
                    {
                        StartCoroutine(off(pt[6], 6));
                    }
                    test[6] =  particle.pParticle(pt[6], test[6]);
                }
                break;
            case 8:
                if (remove_trash.cnt == 33 || pzNum2[7] == 1)
                {
                    pzNum2[7] = 1;
                    img.sprite = sprite_img;

                    if (test[7] == 1)
                    {
                        StartCoroutine(off(pt[7], 7));
                    }
                    test[7] =  particle.pParticle(pt[7], test[7]);
                }
                break;
        }
    }

    IEnumerator off(GameObject pt, int index)
    {
        yield return new WaitForSeconds(0.8f);
        pt.SetActive(false);
        test[index] = 2;
        
    }
}
