using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabacoo : MonoBehaviour
{
    public static bool tabac;
    // Start is called before the first frame update
    void Start()
    {
        tabac = false;
    }

    private void OnMouseDown()
    {
        tabac = true;
        Destroy(this.gameObject);
    }
}
