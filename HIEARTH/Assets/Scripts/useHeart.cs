using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useHeart : MonoBehaviour
{
    public void use()
    {
        if(stm.heart > 0)
        {
            stm.heart--;
            stm.min = 4;
            stm.sec = 60;
            PlayerPrefs.SetInt("heart", stm.heart); PlayerPrefs.SetInt("min", stm.min);
            PlayerPrefs.SetFloat("sec", stm.sec);
            PlayerPrefs.Save();
        }
    }
}
