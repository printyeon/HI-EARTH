using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class monol : MonoBehaviour
{
    public TextMeshProUGUI[] monChat = new TextMeshProUGUI[5];
    int index;
    
    string[] npcChat_I =
   {
            "'어쩌다 숲이 이렇게\n변해버린 거지'",
            "'...'",
            "'인간이 버린 쓰레기들로 인해\n숲과 동물들이 망가졌어'",
            "'다람쥐가 해주는 말로는....\n바다도 오염된 건가?'",
            "'당장 바다로 가봐야겠어'",
    };
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i<monChat.Length; i++)
        {
            monChat[i].text = "";

        }
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.transform.tag == "monol")
        {
            Debug.Log("asdfsadfadfsa");

            if (index == 0)
            {
                monChat[index].text = npcChat_I[index];
                index++;
            }
            else if (index == 1)
            {
                monChat[index].text = npcChat_I[index];
                index++;
            }
            else if(index == 2)
            {
                monChat[index].text = npcChat_I[index];
                index++;
            }
            else if(index == 3)
            {
                monChat[index].text = npcChat_I[index];
                index++;
            }
            else if(index == 4)
            {
                monChat[index].text = npcChat_I[index];
                index++;
            }



        }
        
        
    }
    
}
