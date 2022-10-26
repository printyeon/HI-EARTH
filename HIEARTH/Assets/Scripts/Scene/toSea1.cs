using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSea1 : MonoBehaviour
{
    public Object cam;
    public void SceneChange()
    {
        SceneManager.LoadScene("stageSea1");
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

