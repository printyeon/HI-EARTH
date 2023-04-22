using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class isDie : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            PlayerManager.isGameOver = true;
            //Time.timeScale = 0;
            Invoke("die", 0.2f);
            
        }
    }
    void die()
    {
       
        gameOverScreen.SetActive(true);
        Time.timeScale = 1;
    }
}
