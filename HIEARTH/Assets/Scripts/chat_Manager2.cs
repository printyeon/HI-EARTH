using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_Manager2 : MonoBehaviour
{



    public Text npcTextn;

    string[] npcChat_N =
    {
        "하하 젊은이가 이렇게 마을을 찾아오는건 오랜만이야",
        "거 가는 길에 있는 쓰레기들을 모두 치워주겠다고 약속하면, 배를 빌려주도록 하지",
        "하나도 빠짐없이 부탁하네 물 위에 둥둥 떠 있는 것까지 말이야."
    };
    void Start()
    {
        npcTextn.text = npcChat_N[0];

    }

    public void OnTouchedN()
    {
        if (chat_Manger.touchNum == 1)
        {

            npcTextn.text = npcChat_N[1];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 2)
        {
            npcTextn.text = npcChat_N[2];
            chat_Manger.touchNum++;//3
        }
        else if (chat_Manger.touchNum == 3)
        {
            npc.ischatdone = 2;
            npc.npcNum[4] = 1;
        }

    }
}
