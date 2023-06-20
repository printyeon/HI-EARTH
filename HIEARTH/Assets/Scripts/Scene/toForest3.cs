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
        playerMove.dont_move = true;
        Invoke("movestop", 0.001f);
    }

    public void SceneChange()
    {
        npc.ischatdone = 2;
        SceneManager.LoadScene("stageForest3");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
        Time.timeScale = 1f;
        Audio.seaStop = true;
        Audio.mainStop = true;
        Audio.foreStop = false;
        playerMove.dont_move = false;
    }
    void movestop()
    {
        playerMove.dont_move = false;
        playerMove.right = false;
        playerMove.left = false;
    }
}

