using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tost1 : MonoBehaviour
{

    public void Start()
    {
        Invoke("SceneChange", 32f);
        
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("stage1Scene");
    }

}
