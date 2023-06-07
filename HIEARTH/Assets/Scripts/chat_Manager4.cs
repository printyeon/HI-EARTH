using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class chat_Manager4 : MonoBehaviour
{
    public Text npcTexturt;
    public Text npcTextwha;
    public GameObject npcTextwhaobj;

    public Text npcTextwha2;
    public GameObject npcTextwha2obj;
    public Text npcTextf;
    public Text npcTextb;
    public GameObject turtle;
    public GameObject wh;
    public GameObject quizF;
    public GameObject chatB;

    public GameObject testT;
    public GameObject testW;

    public GameObject touch1;
    public GameObject touch2;

    private void Update()
    {
    //    Debug.Log("touchNum : " + chat_Manger.touchNum);
        //Debug.Log("testW : " + testW.transform.position);
        //Debug.Log("testT : " + testT.transform.position);

    }
    string[] npcChat_Turt =
        {
            "ㅈ..저기!! (꼬르륵ㄱ) 나 좀 올려줘!!",
            "엣퉤퉤 고마워 코에 그만 빨대가 끼어서 올라오지도 못하고 진짜 죽을 뻔 했네",
            "보답으로 하나 알려주는데,",
            "저기에…거품으로 이루어진 \n알 수 없는 녀석이 있는 것 같아..."
        };

    string[] npcChat_Wha =
    {
        "저기 혹시 제발 저를 구해주실수 있나요..?",
        "아직도 고래잡이를 하다니..",
        "저를 바다로 밀어주시시면 돼요..",
        "감사합니다 저의 영웅님",
        "저런 나쁜 어부들에게 오늘도 제 고래 친구들은 잡히고 있어요",
        "앞으로도 고래 잡이에 반대에 대해 관심을 가져주세요"
    }; 

    string[] npcChat_F =
    {
        "네가 뭔↓데↑ 갸를 꺼내주나! 다 물어줄기↑가↓?",
        "불법이고 뭐고↑ 내가 잡아다 \n팔↑겠다는데 니↑가↓ 뭔상관이냐?",
        "고래가 뭐 도움되는게 있노↓ 뭐가있↑나↓",
        "....그..그런거였나↓..",
        "내↑가 환경을↑ 파괴하고 있었나↓..",
        "그래↓ 앞으로↓ 고래를 잡↑지↓ 않도록↓ 하긋다↓"
    };

    string[] npcChat_B =
    {
        "안녕 난 인간으로부터 탄생한 버블버블",
        "고마워 너희 인간 덕분에 내 힘이 점점 커지는게 느껴져",
        "비록 이곳이 생명채가 살기 어려워져서",
        "귀여운 물고기들이 다 죽었지만 그쯤이야",
        "너희 인간도 마찬가지잖아?",
        "나와 바다에 둥둥 떠다니는 쓰레기는 누구의 작품인지...",
        "이 광경을 부디 잊지 말아줬으면 해"
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
        touch1.SetActive(true);
        //chat_Manger.touchNum++;
    }

    public void chatB1()
    {
        touch2.SetActive(true);
        npcTextb.text = npcChat_B[3];
        //chat_Manger.touchNum++;
        chatB.SetActive(false);
        npcTextb.text = npcChat_B[4];
    }

    public void OnTouchedTurt()
    {
        if (chat_Manger.touchNum == 1)
        {
            npc4.isDragTclear = 1;
            npcTexturt.text = npcChat_Turt[1];
            //chat_Manger.touchNum++;//2
            // turtle.transform.position = new Vector2(2.7f, turtle.transform.position.y);
            testT.transform.position = new Vector3(680.1f, 341.4f, 0.0f);
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

            Debug.Log(npc.ischatdone);
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
            npc4.isDragWclear = 1;
            npcTextwha2.text = npcChat_Wha[3];
            npcTextwhaobj.SetActive(false);
            npcTextwha2obj.SetActive(true);
            //chat_Manger.touchNum++;//2
            //wh.transform.position = new Vector2(20.6f, turtle.transform.position.y);
            testW.transform.position = new Vector3(705.8f, 219.9f, 0.0f);
            testW.transform.eulerAngles = new Vector3(0, 200, 0);
            //testWtxt.transform.eulerAngles = new Vector3(0, -160, 0);
        }
        else if(chat_Manger.touchNum == 4)
        {
            Debug.Log("fffffffffffff");
            npcTextwha2.text = npcChat_Wha[4];
            chat_Manger.touchNum++;//2
        }
        else if (chat_Manger.touchNum == 5)
        {
            npcTextwha2.text = npcChat_Wha[5];
            chat_Manger.touchNum++;//2
        }

        else if(chat_Manger.touchNum == 6)
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
            touch1.SetActive(false);
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
            touch2.SetActive(false);
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


