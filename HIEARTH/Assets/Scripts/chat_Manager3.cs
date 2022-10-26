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
        "아오-!! 내 집! 내 밥! 뭐냐고!! 왜 다 타버린거야?",
        "이게 화재의 원인...? 널 믿을 수 있을까? 내게 믿음을 줘!",
        "정답!! 좋아 널 믿어줄게!"
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
            npc.ischatdone = 2;
            block.SetActive(false);
            npc.npcNum[3] = 1;
        }


    }


}

