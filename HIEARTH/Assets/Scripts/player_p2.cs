using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_p2 : MonoBehaviour
{
    public static bool rock5;
    public static Vector3 position = new Vector3(-7.9f, 1.6f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        rock5 = false;
        this.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 37.5) rock5 = true;
    }
}
