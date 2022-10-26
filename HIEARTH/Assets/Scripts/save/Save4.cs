using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save4 : MonoBehaviour
{
    public GameObject save5;

    public GameObject camera;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //save
        if (collision.transform.tag == "Respawn4")
        {
            Save2.isstg2 = false;
            saveloc();

        }

        //save
        if (collision.transform.tag == "save5")
        {
            save.loc = 5;
            PlayerPrefs.SetInt("saveloc", save.loc);
            save5.GetComponent<BoxCollider2D>().enabled = false;

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);

        }
    }

    void saveloc()
    {
        save.loc = PlayerPrefs.GetInt("saveloc");
        npc.npcNum[0] = PlayerPrefs.GetInt("savenpc");
        npc.npcNum[1] = PlayerPrefs.GetInt("savenpc1");
        npc.npcNum[2] = PlayerPrefs.GetInt("savenpc2");
        npc.npcNum[3] = PlayerPrefs.GetInt("savenpc3");

        if (save.loc == 5)
        {
            this.transform.position = new Vector3(6.6f, 0.0f, 90.0f);
            camera.transform.position = new Vector3(6.6f, 0.0f, -10.0f);
        }
    }
}
