using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backSea2 : MonoBehaviour
{
    public float point;
    void Update()
    {
        if (point > this.transform.position.x)
        {
            SceneManager.LoadScene("stageSea2");
            player_p2.position = new Vector3(30.0f, this.transform.position.y, 0f);
            npc.ischatdone = 2;
            playerMove.dont_move = true;
            
            //Invoke("movestop", 0.01f);
        }

    }
    void movestop()
    {
        Debug.Log("sdfdfdfdfdfddddddddddd");
        playerMove.dont_move = false;
        playerMove.right = false;
    }
}
