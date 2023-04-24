using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  
public class checkPZ1 : MonoBehaviour
{
    public GameObject PZcheck;
    public GameObject PZchecktxt;

    // Update is called once per frame
    void Update()
    {
        if (puzlTrue())
        {
            PZcheck.SetActive(false);
        }

    }

     

    public void PZcheckF()
    {

        if (puzlTrue())
        {
            PZchecktxt.SetActive(true);
            Invoke("PZcheckFtxt", 1f);
        }
        else
        {
            SceneManager.LoadScene("stageSea1");
            Time.timeScale = 1f;
        }
    }

    void PZcheckFtxt()
    {

        PZchecktxt.SetActive(false);
    }

    bool puzlTrue()
    {
        for(int i=0; i< 8; i++)
        {
            if (pz1.pzNum[i] == false) return false;
        }
        return true;
    }
}
