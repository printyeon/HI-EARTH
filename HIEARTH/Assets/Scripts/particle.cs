using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    //public GameObject pt1;
    // Start is called before the first frame update

/*
    void Start()
    {
        
    }

     // Update is called once per frame
    void Update()
    {
        
    }
    */
    public static void Reset(GameObject pt, int test)
    {
        pt.SetActive(false);
        test = 0;
    }



    public static int pParticle(GameObject pt, int test)
    {
        
        //안보여지면 1
        if (!pt.activeSelf && test == 0)
        {
            test = 1;

        }

        if (test == 1)
        {
            pt.SetActive(true);
           // Invoke("off", 0.6f);
        }

        if (test == 2)
        {
            pt.SetActive(false);
        }
        return test;
        /*
         
          //1이면 0.6초뒤에 꺼지게하기
        if (test == 1)
        {
            pt.SetActive(true);
            Invoke("off", 0.6f);
        }

              if (test == 1)
        {
            Invoke("off", 0.6f);
        }
         
         */

    }

    public void off(GameObject pt, int test)
    {

        pt.SetActive(false);
        test = 2;
    }


}
