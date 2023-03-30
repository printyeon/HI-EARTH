using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragW : MonoBehaviour
{
    public static bool isPicClear2 = false;


    public GameObject wha;
    public GameObject whab;


    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        wha.transform.position = objPosition;
        Debug.Log(objPosition);

        float Distance1 = Vector2.Distance(wha.transform.position, whab.transform.position);
        if (Distance1 < 0.8)
        {
            wha.transform.position = whab.transform.position;
            isPicClear2 = true;

        }
      

    }

  
}
