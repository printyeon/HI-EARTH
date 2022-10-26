using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save5 : MonoBehaviour
{
    public GameObject save22;


    public GameObject camera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //save
        if (collision.transform.tag == "Respawn6")
        {
            Save2.isstg2 = true;
            saveloc2();
        }

        //save
        if (collision.transform.tag == "save2")
        {
            Save2.loc2 = 2;
            PlayerPrefs.SetInt("saveloc2", Save2.loc2);
            save22.GetComponent<BoxCollider2D>().enabled = false;
            PlayerPrefs.SetInt("savenpc4", npc.npcNum[4]);
            PlayerPrefs.SetInt("savenpc5", npc.npcNum[5]);
            PlayerPrefs.SetInt("savenpc6", npc.npcNum[6]);
            PlayerPrefs.SetInt("savenpc7", npc.npcNum[7]);
            PlayerPrefs.SetInt("savenpc8", npc.npcNum[8]);
        }
    }

    void saveloc2()
    {
        Save2.loc2 = PlayerPrefs.GetInt("saveloc2");
        npc.npcNum[4] = PlayerPrefs.GetInt("savenpc4");
        npc.npcNum[5] = PlayerPrefs.GetInt("savenpc5");
        npc.npcNum[6] = PlayerPrefs.GetInt("savenpc6");
        npc.npcNum[7] = PlayerPrefs.GetInt("savenpc7");
        npc.npcNum[8] = PlayerPrefs.GetInt("savenpc8");

        if (Save2.loc2 == 2)
        {
            this.transform.position = new Vector3(27.9f, 1.0f, 0.0f);
            camera.transform.position = new Vector3(27.9f, 0.0f, -10.0f);
        }


    }
}
