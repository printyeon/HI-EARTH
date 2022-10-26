using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backForest1 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if (point > this.transform.position.x)
        {
            SceneManager.LoadScene("stageForest1");
            player_p1.position = new Vector3(84.0f, this.transform.position.y, 0f);
        }

    }
}
