using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearGame1 : MonoBehaviour
{
    public float point = 87.0f;
    public GameObject gameClear;
    void Update()
    {
        if (point < this.transform.position.x)
        {
            gameClear.SetActive(true);
        }

    }
}
