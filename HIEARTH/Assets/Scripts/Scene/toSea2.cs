using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSea2 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if (this.transform.position.x >= point)
        {
            SceneManager.LoadScene("stageSea2");
        }
    }

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("stageSea2");
    }
}
