using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSea2 : MonoBehaviour
{
    public float point;
    void Update()
    {
        Debug.Log("x" + this.transform.position.x);
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
        npc.ischatdone = 2;
        SceneManager.LoadScene("stageSea2");
        Audio.seaStop = false;
        Audio.mainStop = true;
        Audio.foreStop = true;
    }
}
