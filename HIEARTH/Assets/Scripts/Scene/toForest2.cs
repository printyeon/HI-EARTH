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
        playerMove.dont_move = true;
        Invoke("movestop", 0.001f);
    }

    public void SceneChange()
    {
        npc.ischatdone = 2;
        SceneManager.LoadScene("stageForest2");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
        Time.timeScale = 1f;
        Audio.seaStop = true;
        Audio.mainStop = true;
        Audio.foreStop = false;
        //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
        playerMove.dont_move = false;
    }
    void movestop()
    {
        playerMove.dont_move = false;
        playerMove.right = false;
        playerMove.left = false;
    }
}
