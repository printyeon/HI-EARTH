using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_Manager3 : MonoBehaviour
{

    public Text npcTexts;
    public GameObject quizS;

    public GameObject block;

    string[] npcChat_S =
    {
        "담배 꽁초 때문에 내 집이랑.....내 도토리가..",
        "너희같은 인간을 믿을 수 있을까? 내게 믿음을 줘!",
        "제법 믿을만한 인간이구나\n내 포근한 안락처...숲..바다..",
        "다 망가져버렸어 어쩌다 이렇게 된 거지?",
        "그 답을 알고 있니?"
    };

    void Start()
    {
        npcTexts.text = npcChat_S[0];
    }

    public void offquizS()
    {
        quizS.SetActive(false);
    }

    public void OnTouchedS()
    {
        if (chat_Manger.touchNum == 1)
        {

            npcTexts.text = npcChat_S[1];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 2)
        {
            quizS.SetActive(true);
            npcTexts.text = npcChat_S[2];
            chat_Manger.touchNum++;//3
        }


        else if (chat_Manger.touchNum == 3)
        {
            chat_Manger.touchNum++;//2
            npcTexts.text = npcChat_S[3];
        }

        else if (chat_Manger.touchNum == 4)
        {
            chat_Manger.touchNum++;//2
            npcTexts.text = npcChat_S[4];
        }

        else if (chat_Manger.touchNum == 5)
        {
            npc.ischatdone = 2;
            block.SetActive(false);
            npc.npcNum[3] = 1;
        }


    }


}

