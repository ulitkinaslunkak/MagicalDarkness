using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public string color;
    public bool playerinrange;
    public GameObject wand;

    private void Start()
    {
        wand.GetComponent<SSSSShoot>().enabled = false;
    }

    void Update()
    {
        //Destroy(gameObject);
        playerinrange = false;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            playerinrange = true;
            wand.GetComponent<SSSSShoot>().enabled = true;
            Destroy(gameObject);
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            playerinrange = false;
        }
    }
}
