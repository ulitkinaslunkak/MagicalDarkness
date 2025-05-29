using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public GameObject explosionDamage;
    public int damage;
    public int enemies;


    public Slider healthBar;

    private void Start()
    {
        damage = explosionDamage.GetComponent<CustomBullet>().explosionDamage;
    }
    //Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Damage();
        }
    }

    private void Damage()
    {
        health -= damage;
        if (health <= 0)
        {
            //animator.SetBool("Death", true);
            EnemyCount.enemies += 1;
            Animator.Destroy(gameObject);
            healthBar.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        healthBar.value = health;
    }
}

