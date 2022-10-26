using UnityEngine;
using UnityEngine.SceneManagement;

public class save : MonoBehaviour
{
    public GameObject save1;
    public GameObject save2;

    public GameObject camera;

    public static bool reset = false;

    public static int loc = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //save
        if (collision.transform.tag == "Respawn")
        {
            Save2.isstg2 = false;
            saveloc();

        }

        //save
        if (collision.transform.tag == "save")
        {
            loc = 1;
            PlayerPrefs.SetInt("saveloc", loc);
            save1.GetComponent<BoxCollider2D>().enabled = false;

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }

        //save
        if (collision.transform.tag == "save2")
        {
            loc = 2;
            PlayerPrefs.SetInt("saveloc", loc);
            save2.GetComponent<BoxCollider2D>().enabled = false;

            PlayerPrefs.SetInt("savenpc", npc.npcNum[0]);
            PlayerPrefs.SetInt("savenpc1", npc.npcNum[1]);
            PlayerPrefs.SetInt("savenpc2", npc.npcNum[2]);
            PlayerPrefs.SetInt("savenpc3", npc.npcNum[3]);
        }
    }

    void saveloc()
    {

        loc = PlayerPrefs.GetInt("saveloc");
        npc.npcNum[0] = PlayerPrefs.GetInt("savenpc");
        npc.npcNum[1] = PlayerPrefs.GetInt("savenpc1");
        npc.npcNum[2] = PlayerPrefs.GetInt("savenpc2");
        npc.npcNum[3] = PlayerPrefs.GetInt("savenpc3");

        if (loc == 1)
        {
            this.transform.position = new Vector3(24.6f, 0.4f, 0.0f);
            camera.transform.position = new Vector3(24.6f, 0.0f, -10.0f);
        }


        if (loc == 2)
        {
            this.transform.position = new Vector3(60.0f, 0.1f, 0.0f);
            camera.transform.position = new Vector3(60.0f, 0.0f, -10.0f);
        }

        if (loc == 3)
        {
            SceneManager.LoadScene("stageForest2");
        }

        if (loc == 4)
        {
            SceneManager.LoadScene("stageForest2");
        }

        if (loc == 5)
        {
            SceneManager.LoadScene("stageForest3");
        }



    }
}





