using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toForest3 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if (this.transform.position.x >= point)
            SceneManager.LoadScene("stageForest3");
    }

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("stageForest3");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
        Time.timeScale = 1f;
    }
}

