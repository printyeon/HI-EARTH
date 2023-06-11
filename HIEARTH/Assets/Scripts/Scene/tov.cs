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
            Audio.seaStop = false;
            Audio.foreStop = true;
            Audio.mainStop = true;
        }
        else
        {
            SceneManager.LoadScene("stage1Scene");
            Audio.seaStop = true;
            Audio.foreStop = true;
            Audio.mainStop = false;
        }
      
    }
}
