using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{
    bool start;
    public GameObject smoke;
    public GameObject ship;
    // Start is called before the first frame update 20.5¿¡¼­ ¸ØÃß±â
    void Start()
    {
        start = false;
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
                    GameObject.Find("player").transform.position += Vector3.right * 1.0f * Time.deltaTime;
                    ship.transform.position += Vector3.right * 1.0f * Time.deltaTime;
                    smoke.SetActive(true);
                }
                else ship.transform.position += Vector3.right * 1.0f * Time.deltaTime;

            }
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
