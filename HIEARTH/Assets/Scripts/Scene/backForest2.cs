using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backForest2 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if (point > this.transform.position.x)
        {
            SceneManager.LoadScene("stageForest2");
            player_p2.position = new Vector3(98.0f, this.transform.position.y, 0f);
        }

    }
}
