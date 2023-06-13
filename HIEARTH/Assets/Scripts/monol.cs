using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class monol : MonoBehaviour
{
    public Text[] monChat = new Text[5];

    string[] npcChat_I =
   {
            "어쩌다 숲이 이렇게 변해버린거지",
            "...",
            "인간이 버린 쓰래기들로 인해 숲이, 동물들이 망가졌어",
            "다람쥐가 해주는 말로는....바다도 오염된건가?",
            "당장 바다로 가봐야겠어",
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int index = 0;
        while (index>5)
        {
            if (collision.transform.tag == "monol")
            {

                monChat[index].text = npcChat_I[index];
            }
            index++;
        }
        
        
    }
}
