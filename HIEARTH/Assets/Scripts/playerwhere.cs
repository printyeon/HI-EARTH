using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class playerwhere : MonoBehaviour
{


    public static Vector3 position = new Vector3(-7.9f, 1.6f, 0f);

    void Update()
    {

        Vector3 pos;
        pos = this.gameObject.transform.position;



        Debug.Log("pos : " + pos);
    }

     

}
