using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save2 : MonoBehaviour
{
    public GameObject save1;


    public GameObject camera;

    public static bool reset2 = false;

    public static int loc2 = 0;
    public static bool isstg2 = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //save
        if (collision.transform.tag == "Respawn5")
        {
            isstg2 = true;
            saveloc2();
        }

        //save
        if (collision.transform.tag == "save")
        {
            loc2 = 1;
            PlayerPrefs.SetInt("saveloc2", loc2);
            save1.GetComponent<BoxCollider2D>().enabled = false;
            PlayerPrefs.SetInt("savenpc4", npc.npcNum[4]);
            PlayerPrefs.SetInt("savenpc5", npc.npcNum[5]);
            PlayerPrefs.SetInt("savenpc6", npc.npcNum[6]);
            PlayerPrefs.SetInt("savenpc7", npc.npcNum[7]);
            PlayerPrefs.SetInt("savenpc8", npc.npcNum[8]);

        }

    }

    void saveloc2()
    {

        loc2 = PlayerPrefs.GetInt("saveloc2");
        npc.npcNum[4] = PlayerPrefs.GetInt("savenpc4");
        npc.npcNum[5] = PlayerPrefs.GetInt("savenpc5");
        npc.npcNum[6] = PlayerPrefs.GetInt("savenpc6");
        npc.npcNum[7] = PlayerPrefs.GetInt("savenpc7");
        npc.npcNum[8] = PlayerPrefs.GetInt("savenpc8");

        if (loc2 == 1)
        {
            this.transform.position = new Vector3(25.4f, -2.0f, 0.0f);
            camera.transform.position = new Vector3(25.4f, 0.0f, -10.0f);
        }


        if (loc2 == 2)
        {
            SceneManager.LoadScene("stageSea2");
        }

        if (loc2 == 3)
        {
            SceneManager.LoadScene("stageSea3");
        }

        if (loc2 == 4)
        {
            SceneManager.LoadScene("stageSea3");
        }
        if (loc2 == 4)
        {
            SceneManager.LoadScene("stageSea3");
        }

    }
}





