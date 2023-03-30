using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAni : MonoBehaviour
{
    public static bool isPicClear1 = false;
    public static bool isPicClear2 = false;

    public GameObject Turt;
    public GameObject Turtb;

    public GameObject wha;
    public GameObject whab;

    Vector2 TurtPos;
    Vector2 whaPos;


    private void Start()
    {
        TurtPos = Turt.transform.position;
        whaPos = wha.transform.position;
    }

    public void Dragpic1()
    {
        Turt.transform.position = Input.mousePosition;
        Debug.Log("dskfhsl");
    }

    public void Dragpic2()
    {
        wha.transform.position = Input.mousePosition;

    }

    public void Droppic1()
    {
        float Distance1 = Vector2.Distance(Turt.transform.position, Turtb.transform.position);
        if (Distance1 < 50)
        {
            Turt.transform.position = Turtb.transform.position;
            isPicClear1 = true;

        }
        else
        {
            Turt.transform.position = TurtPos;
        }
    }

    public void Droppic2()
    {
        float Distance2 = Vector2.Distance(wha.transform.position, whab.transform.position);
        if (Distance2 < 50)
        {
            wha.transform.position = whab.transform.position;
            isPicClear2 = true;
        }
        else
        {
            wha.transform.position = whaPos;
        }
    }
}
