using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class TimerController : MonoBehaviour
{
    public TMP_Text timeCounter;
    public GameObject player;
    private float startTime;
    public static string finalscore;
    public static int minute;

    private void Start()
    {
        startTime = Time.time;

    }

    private void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timeCounter.text = minutes + ":" + seconds;
        if (PlayerHealth.health1 <= 0 || EnemyCount.enemies == 6)
        {
            finalscore = minutes + ":" + seconds;
            minute = Convert.ToInt32(minutes);
        }
    }
}
