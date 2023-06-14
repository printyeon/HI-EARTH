using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{
    bool start, stop;
    public GameObject smoke;
    public GameObject ship;
    // Start is called before the first frame update 20.5¿¡¼­ ¸ØÃß±â
    void Start()
    {
        start = false;
        stop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ship.transform.position.x >= 20.5) return;
        if (ClickRope.Rope)
        {
            if (start)
            {
                if (!(playerMove.left && playerMove.right))
                {
                    if(stop)GameObject.Find("player").transform.position += Vector3.right * 1.5f * Time.deltaTime;
                    ship.transform.position += Vector3.right * 1.5f * Time.deltaTime;
                    smoke.SetActive(true);
                }
                else ship.transform.position += Vector3.right * 1.5f * Time.deltaTime;

            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            start = true;
            stop = true;
        }

    }
    void OnCollisionExit2D(Collision2D co)
    {
        if (co.collider.tag == "Player")
        {
            stop = false;
        }
    }

}
