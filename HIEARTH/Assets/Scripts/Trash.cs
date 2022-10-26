using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public static bool isTouch;
    void Start()
    {
        isTouch = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isTouch)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        isTouch = true;
    }
}
