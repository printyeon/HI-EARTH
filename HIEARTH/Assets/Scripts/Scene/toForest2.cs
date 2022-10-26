using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toForest2 : MonoBehaviour
{
    public GameObject cam;

    public float point;
    void Update()
    {
        if(this.transform.position.x >= point)
        {
            SceneManager.LoadScene("stageForest2");
        }
    }

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("stageForest2");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
        Time.timeScale = 1f;
        //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
    }
}
