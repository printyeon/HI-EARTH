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
        playerMove.dont_move = true;
        Invoke("movestop", 0.001f);
    }
    public void SceneChange()
    {
        npc.ischatdone = 2;
        SceneManager.LoadScene("stageSea2");
        Audio.seaStop = false;
        Audio.mainStop = true;
        Audio.foreStop = true;
        playerMove.dont_move = false;
       
    }
    void movestop()
    {
        playerMove.dont_move = false;
        playerMove.right = false;
        playerMove.left = false;
    }
}
