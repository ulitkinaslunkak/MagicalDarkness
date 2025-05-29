using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class starts : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }

    void Update()
    {
        if(PlayerHealth.health1 > 0)
        {
            star1.SetActive(true);
            if(TimerController.minute <= 2)
            {
                star2.SetActive(true);
            }

            if(TimerController.minute <= 1)
            {
                star3.SetActive(true);
            }
        }
    }
}
