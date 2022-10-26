using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_p1 : MonoBehaviour
{
    public static bool rock1, rock2, rock4;
    public static Vector3 position = new Vector3(-6.0f, 0f, 0f);

    void Start()
    {
        rock1 = false;
        rock2 = false;
        rock4 = false;
        this.transform.position = position;
    }

    void Update()
    {
        if (this.transform.position.x >= 13.0f) rock1 = true;
        if (this.transform.position.x >= 24.0f) rock2 = true;
        if (this.transform.position.x >= 83.0f) rock4 = true;
    }
}
