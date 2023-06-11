using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSea1 : MonoBehaviour
{
    public Object cam;
    public void SceneChange()
    {
        npc.ischatdone = 2;
        SceneManager.LoadScene("stageSea1");
        Audio.seaStop = false;
        Audio.mainStop = true;
        Audio.foreStop = true;
    }
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void delete()
    {
        PlayerPrefs.DeleteAll();
        Save2.reset2 = true;
    }
}

