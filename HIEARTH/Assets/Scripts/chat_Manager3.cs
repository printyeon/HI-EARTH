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
        "�ƿ�-!! �� ��! �� ��! ���İ�!! �� �� Ÿ�����ž�?",
        "�̰� ȭ���� ����...? �� ���� �� ������? ���� ������ ��!",
        "����!! ���� �� �Ͼ��ٰ�!"
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

