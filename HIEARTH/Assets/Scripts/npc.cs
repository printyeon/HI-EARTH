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
    public GameObject rock;

    private void Start()
    {
        if(npcNum[0] == 0)
            npcK_.GetComponent<BoxCollider2D>().enabled = true;
        if (npcNum[1] == 0)
            npcW_.GetComponent<BoxCollider2D>().enabled = true;
        if (npcNum[2] == 0)
            npcT_.GetComponent<BoxCollider2D>().enabled = true;

        rock.SetActive(false);

        if (pz1.pzNum[4] == 0)
        {
            npcNum[0] = 0;
        }
    }
    private void Update()
    {
       // Debug.Log("ischatdone : " + ischatdone);
        //Debug.Log("npcNum[0] : " + npcNum[0]);
        //playerMove.dont_move = false;
        if (ischatdone == 2 && PlayerManager.isGameOver==false)
        {
            move.SetActive(true);
           playerMove.dont_move = false;
            npc_1.SetActive(false);
            npc_2.SetActive(false);
            npc_3.SetActive(false);
        } 

        if (npcNum[0] == 1 || getTrash.get == 4 || pz1.pzNum[4] == 1)
        {
            npcK_.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (npcNum[1] == 1)
        {
            npcW_.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (npcNum[2] == 1)
        {
            npcT_.GetComponent<BoxCollider2D>().enabled = false;
        }


        if (istrashclear == 1 && PlayerManager.isGameOver == false)
        {
            Debug.Log("sdfhsduhfsdfkj");
            move.SetActive(true);
            playerMove.dont_move = false;
            npc_1.SetActive(false);
            chat_Manger.touchNum = 6;

        }

        if (istrashclear == 2)
        {
            move.SetActive(false);
            playerMove.dont_move = true;
            playerMove.iswalk = false;
            npc_1.SetActive(true);
            istrashclear = 0;
            rock.SetActive(true);

        }
        if(pz1.pzNum[4] == 1 || getTrash.get == 4)
        {
            rock.SetActive(true);
        }

        if (!getFruit.get_fruit)
        {
            npcT_.GetComponent<BoxCollider2D>().enabled = true;
        }
        if (ischatdone == 1)
        {
            rock.SetActive(false);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //코알라와 닿으면
        if (collision.transform.tag == "npcK")
        {
            if (npcNum[0] == 0)
            {
                ischatdone = 1;

                move.SetActive(false);
                playerMove.dont_move = true;
                playerMove.iswalk = false;
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
                playerMove.iswalk = false;
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
                playerMove.iswalk = false;
                npc_3.SetActive(true);
                chat_Manger.touchNum = 1;
                npcT_.GetComponent<BoxCollider2D>().enabled = false;

            }
        }

    }

}
