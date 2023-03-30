using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragT : MonoBehaviour
{
    public static bool isPicClear1 = false;

    public GameObject Turt;
    public GameObject Turtb;


    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Turt.transform.position = objPosition;

        float Distance1 = Vector2.Distance(Turt.transform.position, Turtb.transform.position);
        if (Distance1 < 0.8)
        {
            Turt.transform.position = Turtb.transform.position;
            isPicClear1 = true;

        }
      

    }

  
}
