using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timwOverTXT : MonoBehaviour
{
    private TMP_Text time_TXT;
    private string fin_score;

    void Start()
    {
        time_TXT = GetComponent<TMP_Text>();
    }

    void Update()
    {
        fin_score = TimerController.finalscore;
        time_TXT.text = fin_score;
    }
}