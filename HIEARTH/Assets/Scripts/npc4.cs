using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc4 : MonoBehaviour
{

    public GameObject npcTurt_;
    public GameObject npcWha_;
    public GameObject npcF_;
    public GameObject npcB_;

    public GameObject npc_6 = null;
    public GameObject npc_7 = null;
    public GameObject npc_8 = null;
    public GameObject npc_9 = null;

    public GameObject move;


    private void Update()
    {
        if (npc.ischatdone == 2)
        {

            move.SetActive(true);
            playerMove2.dont_move = false;
            npc_6.SetActive(false);
            npc_7.SetActive(false);
            npc_8.SetActive(false);
            npc_9.SetActive(false);
        }
        if (npc.npcNum[5] == 1)
        {
            npcTurt_.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (npc.npcNum[6] == 1)
        {
            npcWha_.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (npc.npcNum[7] == 1)
        {
            npcF_.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (npc.npcNum[8] == 1)
        {
            npcB_.GetComponent<BoxCollider2D>().enabled = false;
        }


        if (npc.ischatdone == 4)
        {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "npcTurt")
        {
            if (npc.npcNum[5] == 0)
            {

                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                playerMove2.dont_move = true;
                npc_6.SetActive(true);
                chat_Manger.touchNum = 1;

                npcTurt_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        if (collision.transform.tag == "npcWha")
        {
            if (npc.npcNum[6] == 0)
            {

                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                playerMove2.dont_move = true;
                npc_7.SetActive(true);
                chat_Manger.touchNum = 1;

                npcWha_.GetComponent<BoxCollider2D>().enabled = false;

            }
        }

        if (collision.transform.tag == "npcF")
        {
            if (npc.npcNum[7] == 0)
            {

                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                playerMove2.dont_move = true;
                npc_8.SetActive(true);
                chat_Manger.touchNum = 1;

                npcF_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        if (collision.transform.tag == "npcB")
        {

            if (npc.npcNum[8] == 0)
            {


                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                playerMove2.dont_move = true;
                npc_9.SetActive(true);
                chat_Manger.touchNum = 1;

                npcB_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

    }
}