using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getFruit : MonoBehaviour
{
    public static bool get_fruit;
    public Sprite img;
    SpriteRenderer sprite;
    GameObject fruit;
    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        get_fruit = false;
        fruit = GameObject.Find("∆€¡Ò_ø≠∏≈");

    }

    // Update is called once per frame
    void Update()
    {
        if (getStick.Stick)
        {
            if (cnt == 3)
            {
                get_fruit = true;
                fruit.GetComponent<SpriteRenderer>().sprite = img;
                fruit.GetComponent<Rigidbody2D>().gravityScale = 0.7f;
            }
        }
    }
    private void OnMouseDown()
    {
        cnt++;
    }
}
