using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
 
public class pz1 : MonoBehaviour
{
    public GameObject pt1;
    public static int[] pzNum = Enumerable.Repeat<int>(0, 8).ToArray<int>();
    Image img;
    public Sprite sprite_img;
    public static int test = 0;

    void Start()
    {
        img = GetComponent<Image>();
        pt1.SetActive(false);
        test = 0;
    }

    void Update()
    {
        Debug.Log("test : " + test);
        if (player_p1.rock1 || pzNum[0] == 1)
        {
            img.sprite = sprite_img;
            pzNum[0]=1;
            
            //안보여지면 1
            if (!pt1.activeSelf && test==0)
            {
                test = 1;
                
            }
               

             //1이면 0.6초뒤에 꺼지게하기
            if (test == 1 )
            {
                pt1.SetActive(true);
                Invoke("off", 0.6f);
            }
            else if (test == 2)
            {
                pt1.SetActive(false);
            }
            
                
        }
        
    }

    public void off()
    {

        pt1.SetActive(false);
        test = 2;
    }
}
 