using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chat_Manger : MonoBehaviour
{
    public static int touchNum = 0;

    public Text npcTextk;
    public Text npcTextw;
    public Text npcTextt;

    public GameObject quizK;
    public GameObject quizT;
    public GameObject quizW;

    public GameObject chatT;

    // public static bool realclear = false;

    private void Update()
    {
        //Debug.Log(touchNum);
        Debug.Log("touchNum : " + touchNum);
        // Debug.Log("touchNum : "+ touchNum);
        if (npc.istrashclear == 1)
        {
            npcTextk.text = npcChat_K[5];
        }
    }

    //length 7
    string[] npcChat_K =
    {
        "숲에...인간..이라니이..!\n인간! 내가아.. 내는 문제를 맞추도록 해!",
        "너어....제법 하는 녀석이잖아?",
        "그럼 있잖아 가는데 도움을 줄테니까....쓰레기 조옴 주워줄래....? ",
        "헤헤 나는...알다시피 코알라라......쓰레기 줍기에는 어려운점이 많아",
        ".... 도와줄 수 있지이? 쓰레기통안에 담아야 하는거 잊지말고오",
        "고마워어....인간들이 버린 쓰레기 때문에 \n내 친구들이 많이 사라져 버렸어....",
        "너는 그런 사람 아닌 것 같아 잘가"
    };

    //length 4
    string[] npcChat_W =
        {
            "인간이야 인간!!!",
            "이 숲을 또 망치려고!! 내머리 안보여?? 썩 안나가?",
            "그럼 내가 내는 문제를 풀면 지나 갈 수 있게 해주지",
            "환경에 대한 지식이 있는 사람이군\n지나가 하지만 호랑이를 조심해야할걸"
        };

    //legnth 5
    string[] npcChat_T =
    {
        "이곳엔 무슨 볼일이지 인간? 내 기본적인 질문에 답을 할 수 있어야 할거야",
        "내 퀴즈를 맞추다니... 꽤 믿을만한 사람인 것 같군",
        "뜨거운 공기와 사방을 뒤덮은 시커먼 연기.... 나의 보금자리가 불타고 있어.....",
        "고마워 도대체 왜 불이 난건지 알고싶어. 날 도와줄 수 있겠어?",
        "안돼. 이 뒤는 불타는 숲이야 돌아가도록 해\n넌 더 이상 앞으로 갈 수 없어",
        "무슨 열매를 말하는거지?"
    };
    void Start()
    {
        npcTextk.text = npcChat_K[0];
        npcTextw.text = npcChat_W[0];
        npcTextt.text = npcChat_T[0];
    }
    public void offquizK()
    {
        quizK.SetActive(false);
    }

    public void offquizW()
    {
        quizW.SetActive(false);
    }

    public void offquizT()
    {
        Debug.Log("asdfsadffffffffffffffffffsdf");
        quizT.SetActive(false);
        touchNum=2;
    }
    
    public void tNum()
    {
        //Debug.Log("asdfsadffffffffffffffffffsdf");
        //touchNum++;
    }
    
    public void chatT1()
    {
        if(getFruit.get_fruit)
        {
            npcTextt.text = npcChat_T[3];
            touchNum++;
            chatT.SetActive(false);
        }
        else
        {
            npcTextt.text = npcChat_T[5];
            chatT.SetActive(false);
            touchNum++;
        }

    }

    public void chatT2()
    {
                npcTextt.text = npcChat_T[4];
                touchNum++;
                chatT.SetActive(false);
                PlayerManager.isGameOver = true;


    }
    

    public void OnTouchedK()
    {
        if (touchNum == 1)
        {
            quizK.SetActive(true);
            npcTextk.text = npcChat_K[1];
            touchNum++;//2
        }
        else if (touchNum == 2)
        {
            npcTextk.text = npcChat_K[2];
            touchNum++;//3
        }
        else if (touchNum == 3)
        {
            npcTextk.text = npcChat_K[3];
            touchNum++;//4
        }
        else if (touchNum == 4)
        {
            npcTextk.text = npcChat_K[4];
            touchNum++;
        }
        else if (touchNum == 5)
        {

            npcTextk.text = npcChat_K[5];
            npc.istrashclear = 1;
            touchNum++;
        }
        else if (touchNum == 6)
        {
            
            npcTextk.text = npcChat_K[6];
            touchNum++;
        }
        else if (touchNum == 7)
        {
            npc.ischatdone = 2;
            npc.npcNum[0] = 1;

        }

    }

    public void OnTouchedW()
    {
        if (touchNum == 1)
        {

            npcTextw.text = npcChat_W[1];
            touchNum++;//2
        }
        else if (touchNum == 2)
        {

            npcTextw.text = npcChat_W[2];
            touchNum++;//3
        }
        else if (touchNum == 3)
        {
            quizW.SetActive(true);
            npcTextw.text = npcChat_W[3];
            touchNum++;//4
        }

        else if (touchNum == 4)
        {
            npc.ischatdone = 2;
            npc.npcNum[1] = 1;

        }

    }

    public void OnTouchedT()
    {
        if (touchNum == 1)
        {
            quizT.SetActive(true);
            npcTextt.text = npcChat_T[1];
            touchNum=2;//2
        }
        else if (touchNum == 2)
        {
            npcTextt.text = npcChat_T[2];
            touchNum=3;//3
        }
        else if (touchNum == 3)
        {
            chatT.SetActive(true);
            
        }

        else if (touchNum == 4 && getFruit.get_fruit)
        {
            npc.ischatdone = 2;
            npc.npcNum[2] = 1;
        }
        else if (touchNum == 4)
        {
            npc.ischatdone = 2;
            npcTextt.text = npcChat_T[0];
        }



    }

}



