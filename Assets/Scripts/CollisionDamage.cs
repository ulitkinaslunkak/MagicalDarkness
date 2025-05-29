using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == collisionTag)
        {
            PlayerHealth health = other.gameObject.GetComponent<PlayerHealth>();
            health.Damage(collisionDamage);
        }
    }


}
