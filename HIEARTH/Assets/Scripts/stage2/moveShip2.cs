using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip2 : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject ship;
    bool start;
    // Start is called before the first frame update 20.5¿¡¼­ ¸ØÃß±â
    void Start()
    {
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 35.5) return;
        if (start)
        {
            if (!(playerMove.left && playerMove.right))
            {
                GameObject.Find("player").transform.position += Vector3.right * 1.0f * Time.deltaTime;
            }
            this.transform.position += Vector3.right * 1.0f * Time.deltaTime;
            ship.transform.position += Vector3.right * 1.0f * Time.deltaTime;
            go1.transform.position += Vector3.right * 1.0f * Time.deltaTime;
            go2.transform.position += Vector3.right * 1.0f * Time.deltaTime;

        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            start = true;
        }

    }
}
