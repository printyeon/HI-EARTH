using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class DragW : MonoBehaviour
{

    public GameObject wha;
    public GameObject whab;

    void OnMouseDrag()
    {
        if(chat_Manger.touchNum == 3) 
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            wha.transform.position = objPosition;

            float Distance1 = Vector2.Distance(wha.transform.position, whab.transform.position);
            if (Distance1 < 0.8)
            {
                wha.transform.position = whab.transform.position;
                chat_Manger.touchNum++;
                npc4.isDragWclear = 2; ;

            }
        }
       
      

    }

  
}
