using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Drag : MonoBehaviour
{
    float orivector;
    float distance = 10;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
    private void Start()
    {
        orivector = this.transform.position.x;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(SceneManager.GetActiveScene().name == "stageForest2")
        {
            if (collision.transform.tag == "Enemy")
            {
                this.transform.position = new Vector3(orivector, 8.0f, this.transform.position.z);
            }
        }
        
    }
}