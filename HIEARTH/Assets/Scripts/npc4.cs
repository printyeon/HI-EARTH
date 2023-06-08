using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class npc4 : MonoBehaviour
{
    public GameObject npcTurt_;
    public GameObject npcTurt_t;
    public GameObject npcWha_;
    public GameObject npcF_;
    public GameObject npcB_;

    public GameObject npc_6 = null;
    public GameObject npc_7 = null;
    public GameObject npc_8 = null;
    public GameObject npc_9 = null;
     
    public GameObject move; 

    public static int isDragTclear = 0;
    public static int isDragWclear = 0;

    public GameObject npcTurt;

    private void Start()
    {
        if (npc.npcNum[5] == 0)
             npcTurt_t.GetComponent<BoxCollider2D>().enabled = true;
        if (npc.npcNum[6] == 0)
            npcWha_.GetComponent<BoxCollider2D>().enabled = true;
        if (npc.npcNum[7] == 0)
            npcF_.GetComponent<BoxCollider2D>().enabled = true;
        if (npc.npcNum[8] == 0)
            npcB_.GetComponent<BoxCollider2D>().enabled = true;


    }

    private void Update()
    {
        //Debug.Log("asdf" + isDragTclear);
        //Debug.Log("as1df" + isDragWclear);

        if (npc.ischatdone == 2)
        {
            move.SetActive(true);
            playerMove.dont_move = false;
            npc_6.SetActive(false);
            npc_7.SetActive(false);
            npc_8.SetActive(false);
            npc_9.SetActive(false);
        }
        if (npc.npcNum[5] == 1)
        {
            npcTurt_.GetComponent<PolygonCollider2D>().enabled = false;
        }
        else if (npc.npcNum[6] == 1)
        {
            npcWha_.GetComponent<PolygonCollider2D>().enabled = false;
        }
        else if (npc.npcNum[7] == 1)
        {
            npcF_.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (npc.npcNum[8] == 1)
        {
            npcB_.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (isDragTclear == 1)
        {
            Debug.Log("asdf1" + isDragTclear);
            //move.SetActive(true);
            npc_6.SetActive(false);
            //playerMove.dont_move = false;
            isDragTclear = 0;
        }
        if (isDragTclear == 2)
        {
            Debug.Log("asdf1" + isDragTclear);
            move.SetActive(false);
            npc_6.SetActive(true);
            playerMove.dont_move = true;
            isDragTclear = 0;
        }

        if (isDragWclear == 1)
        {
            Debug.Log("as1df" + isDragWclear);
            //move.SetActive(true);
            npc_7.SetActive(false);
           // playerMove.dont_move = false;
        }
        if (isDragWclear == 2)
        {
            Debug.Log("as1df" + isDragWclear);
            move.SetActive(false);
            npc_7.SetActive(true);
            playerMove.dont_move = true;
            isDragWclear = 0;
        }
        if(npc.npcNum[5] == 1)
        {
            npcTurt.GetComponent<BoxCollider2D>().enabled = false;
            npcTurt_.transform.position = new Vector3(2.3f, -1.1f, 0.0f);
        }
        if (npc.npcNum[6] == 1)
        {
            npcWha_.transform.position = new Vector3(23.2f, -3.0f, 0.0f);
        }
        if(npc.npcNum[7] == 1)
        {
            npcF_.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (npc.npcNum[8] == 1)
        {
            npcB_.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "npcTurt")
        {
            if (npc.npcNum[5] == 0)
            {

                npc.ischatdone = 1;

                //camera.transform.position = new Vector3(11.0f, 0.0f, -10.0f);
                //this.transform.position = new Vector3(12.4f, -0.2f, 0.0f);

                move.SetActive(false);
                playerMove.dont_move = true;
                npc_6.SetActive(true);
                chat_Manger.touchNum = 1;

                npcTurt_t.GetComponent<BoxCollider2D>().enabled = false;
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
                playerMove.dont_move = true;
                npc_7.SetActive(true);
                if (chat_Manger.touchNum != 3)
                {
                    chat_Manger.touchNum = 1;
                }


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
                playerMove.dont_move = true;
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
                playerMove.dont_move = true;
                npc_9.SetActive(true);
                chat_Manger.touchNum = 1;

                npcB_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

    
}
   
}