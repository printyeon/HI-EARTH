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
        if (pz1.pzNum == 8)
        {
            PZcheck.SetActive(false);
        }

    }



    public void PZcheckF()
    {

        if (pz1.pzNum != 8)
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
}
