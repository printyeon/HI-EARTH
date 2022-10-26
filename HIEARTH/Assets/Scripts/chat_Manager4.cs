using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_Manager4 : MonoBehaviour
{
    public Text npcTexturt;
    public Text npcTextwha;
    public Text npcTextf;
    public Text npcTextb;
    public GameObject turtle;
    public GameObject wh;
    public GameObject quizF;
    public GameObject chatB;


    string[] npcChat_Turt =
        {
            "��..����!! (��������) �� �� �÷���!!",
            "��ơơ ���� ��¥ ���� �� �߳�",
            "�������� �ϳ� �˷��ִµ�,",
            "���� ���⿡����ǰ���� �̷���� \n�� �� ���� �༮�� �ִ� �� ����..."
        };

    string[] npcChat_Wha =
    {
        "���� Ȥ�� ���� ���� �����ֽǼ� �ֳ���..?",
        "���� �� ���� ��ο��� �����Ծ��..",
        "���� �ٴٷ� �о��ֽýø� �ſ�..",
        "�����մϴ� ���� ������",
        "���� ���� ��ε鿡�� ���õ� �� �� ģ������ ������ �־��",
        "������ ������ ģ������ ���� �����ּ���..!!"
    };

    string[] npcChat_F =
    {
        "�װ��� ���鵥�� ���踦�� �����ֳ�!",
        "�� �����ٱ�谡��?",
        "�ҹ��̰�� ����� ���� ��ƴ� \n�ȡ�ڴٴµ��� �ϡ鰡�� ������̳ġ�?",
        "....��..�׷��ſ�����..",
        "���谡 ȯ������ �ı��ϰ� �־�����..",
        "�׷��� �����Ρ� ���� ������� �ʵ��ϡ� �ϱߴ١�"
    };

    string[] npcChat_B =
    {
        "�ʡ�! ����!!!..���",
        "�װ� �ٴٸ� ���� ���������ݾ�!!!!..���",
        "�����⸦ �� �ֿ��ٰ�? �ơ��׷��� ����?..���",
        "���� �ٴٰ� ����������.. �Ϳ��� ������� �̷��� ���߾�",
        "��.��.�׷�.����",
        "������ ���ݸ� �ֿ��൵ �� ������� �� �� �����ž�..���",
        "�����ؼ� �̾�..�߰�..���"
    };

    void Start()
    {
        npcTexturt.text = npcChat_Turt[0];
        npcTextwha.text = npcChat_Wha[0];
        npcTextf.text = npcChat_F[0];
        npcTextb.text = npcChat_B[0];

    }

    public void offquizF()
    {
        quizF.SetActive(false);
    }

    public void chatB1()
    {
        npcTextb.text = npcChat_B[3];
        //chat_Manger.touchNum++;
        chatB.SetActive(false);
        npcTextb.text = npcChat_B[4];
    }

    public void OnTouchedTurt()
    {
        if (chat_Manger.touchNum == 1)
        {



            npcTexturt.text = npcChat_Turt[1];
            chat_Manger.touchNum++;//2
            turtle.transform.position = new Vector2(2.7f, turtle.transform.position.y);
        }

        else if (chat_Manger.touchNum == 2)
        {

            npcTexturt.text = npcChat_Turt[2];
            chat_Manger.touchNum++;//2
        }

        else if (chat_Manger.touchNum == 3)
        {

            npcTexturt.text = npcChat_Turt[3];
            chat_Manger.touchNum++;//2
        }

        else if (chat_Manger.touchNum == 4)
        {
            npc.ischatdone = 2;
            npc.npcNum[5] = 1;
        }

    }

    public void OnTouchedWha()
    {
        if (chat_Manger.touchNum == 1)
        {
            npcTextwha.text = npcChat_Wha[1];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 2)
        {
            npcTextwha.text = npcChat_Wha[2];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 3)
        {

            npcTextwha.text = npcChat_Wha[3];
            chat_Manger.touchNum++;//2
            wh.transform.position = new Vector2(20.6f, turtle.transform.position.y);
        }
        else if (chat_Manger.touchNum == 4)
        {
            npcTextwha.text = npcChat_Wha[4];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 5)
        {
            npcTextwha.text = npcChat_Wha[5];
            chat_Manger.touchNum++;//2
        }

        else if (chat_Manger.touchNum == 6)
        {
            npc.ischatdone = 2;
            npc.npcNum[6] = 1;
        }


    }

    public void OnTouchedF()
    {
        if (chat_Manger.touchNum == 1)
        {

            npcTextf.text = npcChat_F[1];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 2)
        {

            npcTextf.text = npcChat_F[2];
            chat_Manger.touchNum++;//3
            quizF.SetActive(true);
        }

        else if (chat_Manger.touchNum == 3)
        {

            npcTextf.text = npcChat_F[3];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 4)
        {

            npcTextf.text = npcChat_F[4];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 5)
        {

            npcTextf.text = npcChat_F[5];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 6)
        {
            npc.ischatdone = 2;
            npc.npcNum[7] = 1;
        }


    }

    public void OnTouchedB()
    {
        if (chat_Manger.touchNum == 1)
        {

            npcTextb.text = npcChat_B[1];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 2)
        {
            npcTextb.text = npcChat_B[2];
            //
            chat_Manger.touchNum++;//2

        }
        else if (chat_Manger.touchNum == 3)
        {

            npcTextb.text = npcChat_B[3];
            chat_Manger.touchNum++;//2

        }
        else if (chat_Manger.touchNum == 4)
        {

            chatB.SetActive(true);
            //npcTextb.text = npcChat_B[4];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 5)
        {

            npcTextb.text = npcChat_B[5];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 6)
        {

            npcTextb.text = npcChat_B[6];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 7)
        {
            npc.ischatdone = 2;
            npc.npcNum[8] = 1;
        }


    }


}


