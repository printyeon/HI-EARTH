using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRope : MonoBehaviour
{
    int cnt;
    public static bool Rope;
    // Start is called before the first frame update
    void Start()
    {
        cnt = 0;
        Rope = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cnt == 4)
        {
            Rope = true;
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        cnt++;
    }
}
