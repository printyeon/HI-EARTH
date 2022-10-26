using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toForest1 : MonoBehaviour
{
    public GameObject cam;
    public void SceneChange()
    {
        SceneManager.LoadScene("stageForest1");
        player_p1.position = new Vector3(-6.0f, 0f, 0f);
        Time.timeScale = 1f;
        //cam.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
    }
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    public void delete()
    {
        PlayerPrefs.DeleteAll();
        save.reset = true;
    }
}
