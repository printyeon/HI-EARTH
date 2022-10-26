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
            "ㅈ..저기!! (꼬르륵ㄱ) 나 좀 올려줘!!",
            "엣퉤퉤 고마워 진짜 죽을 뻔 했네",
            "보답으로 하나 알려주는데,",
            "저기 여기에…거품으로 이루어진 \n알 수 없는 녀석이 있는 것 같아..."
        };

    string[] npcChat_Wha =
    {
        "저기 혹시 제발 저를 구해주실수 있나요..?",
        "저기 저 나쁜 어부에게 잡혀왔어요..",
        "저를 바다로 밀어주시시면 돼요..",
        "감사합니다 저의 영웅님",
        "저런 나쁜 어부들에게 오늘도 제 고래 친구들은 잡히고 있어요",
        "앞으로 저같은 친구들을 보면 구해주세요..!!"
    };

    string[] npcChat_F =
    {
        "네가↑ 뭔↓데↑ 갸↑를↓ 꺼내주나!",
        "다 물어줄기↑가↓?",
        "불법이고↓ 뭐고↑ 내가 잡아다 \n팔↑겠다는데↓ 니↓가↑ 뭔상관이냐↓?",
        "....그..그런거였나↓..",
        "내↑가 환경을↑ 파괴하고 있었나↓..",
        "그래↓ 앞으로↓ 고래를 잡↑지↓ 않도록↓ 하긋다↓"
    };

    string[] npcChat_B =
    {
        "너…! 너지!!!..우우",
        "네가 바다를 전부 더럽힌거잖아!!!!..우우",
        "쓰레기를 다 주웠다고? 아…그런거 였어?..우우",
        "점점 바다가 더러워져서.. 귀여운 내모습이 이렇게 변했어",
        "어.어.그래.고맙다",
        "쓰레기 조금만 주워줘도 내 본모습을 볼 수 있을거야..우우",
        "오해해서 미안..잘가..우우"
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


