using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_p3 : MonoBehaviour
{
    public static Vector3 position = new Vector3(-7.9f, 0.7f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = position;
        
    }
}