using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tov : MonoBehaviour
{
    bool one = false;
    public void SceneChange()
    {
        if(one == false)
        {
            SceneManager.LoadScene("stageSea4");
            one = true;
        }
        else
        {
            SceneManager.LoadScene("stage1Scene");
        }
        
    }
}
