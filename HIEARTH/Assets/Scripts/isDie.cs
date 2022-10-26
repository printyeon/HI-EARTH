using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDie : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            PlayerManager.isGameOver = true;
            gameOverScreen.SetActive(true);
        }
    }
}
