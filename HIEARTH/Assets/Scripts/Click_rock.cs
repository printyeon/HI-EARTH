using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_rock : MonoBehaviour
{
    int cnt = 0;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public static bool rock3;

    // Start is called before the first frame update
    void Start()
    {
        rock3 = false;
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (cnt > 0)
        {
            spriteRenderer.sprite = sprites[cnt];
            if (cnt == 5)
            {
                gameObject.GetComponent<Rigidbody2D>().mass = 2;
                gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.2f, -2.3f);
                gameObject.GetComponent<BoxCollider2D>().size = new Vector2(5.0f, 4.8f);
                rock3 = true;
            }
        }
    }

    private void OnMouseDown()
    {
        cnt++;
    }
}