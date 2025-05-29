using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class OCHKO_FINl : MonoBehaviour
{
    private TMP_Text score_TXT;
    private int ochki;

    void Start()
    {
        score_TXT = GetComponent<TMP_Text>();
    }

    void Update()
    {
        ochki = EnemyCount.enemies;
        score_TXT.text = Convert.ToString(ochki);
    }
}
