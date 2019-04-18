using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/// <summary>
/// Name: Jaladi Vasavi
/// Project: Unity Alarm
/// Date: April 18, 2019
/// </summary>

[RequireComponent(typeof(AudioClip))]
public class AlarmSound : MonoBehaviour
{
    public AudioClip analogtik;
    public int setjam, setminute;
    private AudioSource analog{get{ return GetComponent<AudioSource>(); }}

    public Text paneljam;

    // Use this for initialization
    void Start()
    {
        paneljam = GetComponent<UnityEngine.UI.Text>();
        analog.clip = analogtik;
        analog.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime time = System.DateTime.Now;
        paneljam.text = time.ToString("hh:mm:ss");
        if(time.Hour == setjam && time.Minute == setminute)
        {
            analog.PlayOneShot(analogtik);
        }
    }
}
