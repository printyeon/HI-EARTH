using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save3 : MonoBehaviour
{
    public GameObject save3;
    public GameObject save4;

    public GameObject camera;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        //save
        if (collision.transform.tag == "Respawn2")
        {
            Save2.isstg2 = false;
            saveloc3();

        }

        //save
        if (collision.transform.tag == "save3")
        {
            save.loc = 3;
            PlayerPrefs.SetInt("saveloc", save.loc);

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);

        }

        //save
        if (collision.transform.tag == "save4")
        {
            save.loc = 4;
            PlayerPrefs.SetInt("saveloc", save.loc);

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }



    }

    void saveloc3()
    {
        save.loc = PlayerPrefs.GetInt("saveloc");
        npc.npcNum[0] = PlayerPrefs.GetInt("savenpc");
        npc.npcNum[1] = PlayerPrefs.GetInt("savenpc1");
        npc.npcNum[2] = PlayerPrefs.GetInt("savenpc2");
        npc.npcNum[3] = PlayerPrefs.GetInt("savenpc3");


        if (save.loc == 3)
        {
            this.transform.position = new Vector3(41.8f, 2.0f, 0.0f);
            camera.transform.position = new Vector3(41.8f, 0.0f, -10.0f);

        }

        if (save.loc == 4)
        {
            this.transform.position = new Vector3(74.1f, -1.6f, 0.0f);
            camera.transform.position = new Vector3(74.1f, 0.0f, -10.0f);

        }

    }
}
