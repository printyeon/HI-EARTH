using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class chat_Manager2 : MonoBehaviour
{
    public Text npcTextn;

    string[] npcChat_N =
    {
            "허허 젊은이가 우리 마을에 찾아오다니 오랜만이구나",
            "우리마을도 한때는 물고기도 많은 푸르고 눈부신 바닷마을이였지....",
            "앞으로 가는 길은 쓰레기로 인해 심각하게 오염되었어. 막혀있지",
            "배를 빌려주도록 할테니, 거 가는 길에 있는 쓰레기들을 치워줄 수 있겠나?",
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
            npcTextn.text = npcChat_N[3];
            chat_Manger.touchNum++;//3
        }
        else if (chat_Manger.touchNum == 4)
        {
            npc.ischatdone = 2;
            npc.npcNum[4] = 1;
        }

    }
}
