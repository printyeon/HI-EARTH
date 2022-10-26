using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_trash : MonoBehaviour
{
    public static int cnt=0;
    public static bool trash;

    void Start()
    {
        trash = false;
    }
    private void OnMouseDown()
    {
        cnt++;
        Destroy(this.gameObject);
    }
}