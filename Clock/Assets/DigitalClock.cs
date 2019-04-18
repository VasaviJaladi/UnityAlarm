using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
/// <summary>
/// Name: Jaladi Vasavi
/// Project: UnityAlarmClock
/// Date: April 18, 2019
/// </summary>
public class DigitalClock : MonoBehaviour
{
    DateTime DateFetcher;
    public Text Hours, Minutes, Seconds;
    public Text AmorPm;
    // Use this for Initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateFetcher = DateTime.Now;
        Hours.text = DateFetcher.Hour.ToString();
        Minutes.text = DateFetcher.Minute.ToString();
        Seconds.text = DateFetcher.Second.ToString();
        if (DateFetcher.Hour > 12 && DateFetcher.Hour< 24)
        {
            AmorPm.text = "PM";
        }
        if(DateFetcher.Hour < 12 && DateFetcher.Hour >= 0)
        {
            AmorPm.text = "AM";
        }
        
        //print("print:" + DateFetcher);
    }
}
