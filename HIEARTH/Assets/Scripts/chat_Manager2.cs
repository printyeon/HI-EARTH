using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_Manager2 : MonoBehaviour
{



    public Text npcTextn;

    string[] npcChat_N =
    {
        "���� �����̰� �̷��� ������ ã�ƿ��°� �������̾�",
        "�� ���� �濡 �ִ� ��������� ��� ġ���ְڴٰ� ����ϸ�, �踦 �����ֵ��� ����",
        "�ϳ��� �������� ��Ź�ϳ� �� ���� �յ� �� �ִ� �ͱ��� ���̾�."
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
