using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomainani : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;
    public static bool isdone = false;

    public void touch()
    {
        canvas.SetActive(true);
        canvas2.SetActive(false);

    }
    public void Awake()
    {
        canvas2.SetActive(true);
        canvas.SetActive(false);
        Invoke("touch", 5.14f);
    }
    
    void Update()
    {

        if (isdone == true)
        {
            canvas.SetActive(true);
            canvas2.SetActive(false);
        }
    }
    
}
