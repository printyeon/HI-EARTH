using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class isDie : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject player;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy" || PlayerManager.isGameOver == true)
        {
            PlayerManager.isGameOver = true;
            //Time.timeScale = 0;

                Invoke("die", 0.2f);
            
        }
    }    
    
    private void Update()
    {
        Debug.Log(" playerMove.dont_move : "  + playerMove.dont_move);
        if (PlayerManager.isGameOver == true)
        {
            Invoke("die", 1.5f);
        }

    }
    
    void die()
    {
        npc.ischatdone = 2;
        
        gameOverScreen.SetActive(true);
        Time.timeScale = 1;
        
    }

}
