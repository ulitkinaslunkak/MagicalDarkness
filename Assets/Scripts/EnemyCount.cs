using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    TMP_Text text;
    [SerializeField] public static int enemies;
    
    void Start()
    {
        enemies = 0;
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = enemies.ToString();
    }
}
