using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_fire : MonoBehaviour
{
    float color =1;

    // Update is called once per frame
    void Update()
    {
        if (Tabacoo.tabac)
        {
            gameObject.GetComponent<SpriteRenderer>().color= new Color(1,1,1,color);
            color -= 0.005f;
        }
        if (color == 0) Destroy(this.gameObject);
    }
}
