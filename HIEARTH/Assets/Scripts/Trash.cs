using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public static bool isTouch;
    public static bool isClear = false;
    void Start()
    {
        isTouch = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTouch)
        {
            isClear = true;
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        isTouch = true;
    }
}
 