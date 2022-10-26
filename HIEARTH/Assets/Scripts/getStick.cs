using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getStick : MonoBehaviour
{
    public static bool Stick;
    void Start()
    {
        Stick = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Stick)
        {
            this.transform.localScale = new Vector3(0f, 0f, 0f);

        }
    }

    private void OnMouseDown()
    {
        Stick = true;
    }
}
