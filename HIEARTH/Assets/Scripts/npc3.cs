using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc3 : MonoBehaviour
{
    public GameObject npcS_;
    public GameObject npc_4 = null;

    public GameObject move;


    private void Update()
    {
        if (npc.ischatdone == 2)
        {

            move.SetActive(true);
            playerMove.dont_move = false;
            npc_4.SetActive(false);
        }

        if (npc.npcNum[3] == 1)
        {
            npcS_.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "npcS")
        {
            if (npc.npcNum[3] == 0)
            {

                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                playerMove.dont_move = true;
                npc_4.SetActive(true);
                chat_Manger.touchNum = 1;

                npcS_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
