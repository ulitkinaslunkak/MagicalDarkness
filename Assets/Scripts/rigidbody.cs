using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetBool("isAttaking"))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

        else
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
