using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    GameObject seaBackgroundMusic;
    AudioSource seabackmusic;

    GameObject foreBackgroundMusic;
    AudioSource forebackmusic;
    
    GameObject mainBackgroundMusic;
    AudioSource mainbackmusic;

    
    public static bool seaStop = false;
    public static bool foreStop = false;
    public static bool mainStop = false;

    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 7 || SceneManager.GetActiveScene().buildIndex == 8 || SceneManager.GetActiveScene().buildIndex == 9)
        {
            seaBackgroundMusic = GameObject.Find("seaAudio");
            seabackmusic = seaBackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
            cAudio(seaBackgroundMusic, seabackmusic);
        }

        else if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 6)
        {
            foreBackgroundMusic = GameObject.Find("foreAudio");
            forebackmusic = foreBackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
            cAudio(foreBackgroundMusic, forebackmusic);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            mainBackgroundMusic = GameObject.Find("mainAudio");
            mainbackmusic = mainBackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
            cAudio(mainBackgroundMusic, mainbackmusic);
        }
    }

    private void Update()
    {

        if (seaStop && seabackmusic!= null)
            seabackmusic.Pause();

        if (foreStop && forebackmusic != null)
            forebackmusic.Pause();

        if (mainStop && mainbackmusic != null)
            mainbackmusic.Pause();
    }

    void cAudio(GameObject BackgroundMusic, AudioSource backmusic)
    {
        if (backmusic.isPlaying) return; //배경음악이 재생되고 있다면 패스
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(BackgroundMusic); //배경음악 계속 재생하게(이후 버튼매니저에서 조작)
        }
    }

}
