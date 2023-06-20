using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toForest1 : MonoBehaviour
{
    public GameObject cam;
    public void SceneChange()
    {
        npc.ischatdone = 2;
        SceneManager.LoadScene("stageForest1");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
        Time.timeScale = 1f;
        Audio.seaStop = true;
        Audio.mainStop = true;
        Audio.foreStop = false;
        //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
       playerMove.dont_move = false;
    }
    private void Start()
    {
        Time.timeScale = 1f;
        playerMove.dont_move = true;
        Invoke("movestop", 0.001f);
    }
    public void delete()
    {
        PlayerPrefs.DeleteAll();
        save.reset = true;
        for (int i = 0; i < pz1.pzNum.Length; i++)
        {
            pz1.pzNum[i] = 0;
        }
        player_p2.rock5 = false;
        getFruit.get_fruit = false;
        player_p1.rock1 = false;
        Tabacoo.tabac = false;
        getTrash.get = 0;
        npc.npcNum[0] = 0;
        player_p1.rock4 = false;
        Click_rock.rock3 = false;
        player_p1.rock2 = false;
    }
    void movestop()
    {
        playerMove.dont_move = false;
        playerMove.right = false;
        playerMove.left = false;
    }
}
