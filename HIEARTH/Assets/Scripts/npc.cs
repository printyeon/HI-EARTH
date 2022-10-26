using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    //npc 숫자
    public static int[] npcNum = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    //대화 끝여부
    public static int ischatdone = 0;

    //카메라 고정
    public GameObject camera;

    //npc
    public GameObject npcK_;
    public GameObject npcW_;
    public GameObject npcT_;
    // public GameObject npcS_;

    //대화창
    public GameObject npc_1 = null;
    public GameObject npc_2 = null;
    public GameObject npc_3 = null;
    // public GameObject npc_4 = null;

    //방향키 끄기
    public GameObject move;



    //쓰레기 퍼즐
    public static int istrashclear = 0;

    private void Update()
    {
        playerMove.dont_move = false;
        if (ischatdone == 2)
        {
            move.SetActive(true);
            playerMove.dont_move = false;
            npc_1.SetActive(false);
            npc_2.SetActive(false);
            npc_3.SetActive(false);
        }

        if (npcNum[0] == 1)
        {
            npcK_.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (npcNum[1] == 1)
        {
            npcW_.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (npcNum[2] == 1)
        {
            npcT_.GetComponent<BoxCollider2D>().enabled = false;
        }


        if (istrashclear == 1)
        {

            move.SetActive(true);
            playerMove.dont_move = false;
            npc_1.SetActive(false);

        }

        if (istrashclear == 2)
        {
            move.SetActive(false);
            playerMove.dont_move = true;
            npc_1.SetActive(true);
            istrashclear = 0;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //코알라와 닿으면
        if (collision.transform.tag == "npcK")
        {
            if (npcNum[0] == 0)
            {

                ischatdone = 1;

                move.SetActive(false);
                playerMove.dont_move = true;
                npc_1.SetActive(true);
                chat_Manger.touchNum = 1;

                npcK_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        //나무와 닿으면
        if (collision.transform.tag == "npcW")
        {
            if (npcNum[1] == 0)
            {
                ischatdone = 1;

                move.SetActive(false);
                playerMove.dont_move = true;
                npc_2.SetActive(true);
                chat_Manger.touchNum = 1;

                npcW_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        if (collision.transform.tag == "npcT")
        {
            if (npcNum[2] == 0)
            {

                ischatdone = 1;

                move.SetActive(false);
                playerMove.dont_move = true;
                npc_3.SetActive(true);
                chat_Manger.touchNum = 1;

                npcT_.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

    }

}
