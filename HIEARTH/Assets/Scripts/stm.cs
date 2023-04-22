using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stm : MonoBehaviour
{
    public Text Timer;
    public Text Heart;

    public static int heart = 5; // 하트 개수
    public static int maxHeart = 5; //최대 하트 개수

    public static DateTime start_time = new DateTime(1970, 1, 1).ToLocalTime();
    public static int min = 5; //분
    public static float sec = 0; //초

    private void Start()
    {
        //heart
        heart = PlayerPrefs.GetInt("heart");

        //시간 가져오기
        var appQuitTime = string.Empty;
        appQuitTime = PlayerPrefs.GetString("time");
        start_time = DateTime.FromBinary(Convert.ToInt64(appQuitTime));

        //현재시간에 빼기
        var timeDifferenceInSec = (int)((DateTime.Now.ToLocalTime() - start_time).TotalSeconds);
        var heartToAdd = timeDifferenceInSec / 300;
        heart += heartToAdd;
        if (heart < maxHeart)
        {
            //남은 시간 저장
            min = PlayerPrefs.GetInt("min");
            if (min < 0) min *= -1;
            min -= (timeDifferenceInSec % 300) / 60;
            sec = PlayerPrefs.GetFloat("sec") - (timeDifferenceInSec % 300) % 60;

            if (sec < 0) sec = 0;
            if (min < 0) min = 0;
        }
        if (heart >= maxHeart)
        {
            sec = 0; min = 0;
        }
    }

    void Update()
    {
        if (heart < maxHeart)
        {
            sec -= Time.deltaTime;
            if (min == 0 && sec < 1)
            {
                heart++;
                min = 4; sec = 59;
            }
            else if (sec < 1)
            {
                min--; sec = 60;
            }
        }
        else { min = 0; sec = 0; }
        Heart.text = heart.ToString();
        Timer.text = string.Format("{0:D1} : {1:D2}", min, (int)sec);
    }

    public void OnApplicationFocus()
    {
        PlayerPrefs.SetInt("heart", heart);
        var appQuitTime = DateTime.Now.ToLocalTime().ToBinary().ToString();
        PlayerPrefs.SetInt("min", min);
        PlayerPrefs.SetFloat("sec", sec);
        PlayerPrefs.SetString("time", appQuitTime);
        PlayerPrefs.Save();
    }

    public void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("heart", heart);
        var appQuitTime = DateTime.Now.ToLocalTime().ToBinary().ToString();
        PlayerPrefs.SetString("time", appQuitTime);
        PlayerPrefs.SetInt("min", min);
        PlayerPrefs.SetFloat("sec", sec);
        PlayerPrefs.Save();
    }

    public void GetHeart()
    {
        switch (this.gameObject.name.ToString())
        {
            case "stm_3_btn":
                heart +=3;
                break;
            case "stm_6_btn":
                heart += 6;
                break;
            case "stm_10_btn":
                heart += 10;
                break;
        }
        PlayerPrefs.SetInt("heart", heart);
    }
}