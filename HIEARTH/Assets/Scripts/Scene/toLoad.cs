using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLoad : MonoBehaviour
{
    void Awake()
    {
        Time.timeScale = 1f;
    }
    public void SceneChange()
            {
        

        if (Save2.isstg2)
                {
                    SceneManager.LoadScene("stageSea1");
                    player_p1.position = new Vector3(-6.0f, 0f, 0f);
                    Time.timeScale = 1f;
                    //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                }
                else
                {
                    SceneManager.LoadScene("stageForest1");
                    player_p1.position = new Vector3(-6.0f, 0f, 0f);
                    Time.timeScale = 1f;
                    //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                }
                
            }

    
}
