using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public int damage;
    public string sceneToLoad;
    public static int totalscore;
    public static int health1;

    public TMP_Text playerHealthText;


    private void Update()
    {
        playerHealthText.text = "" + health;

        if (EnemyCount.enemies == 6)
        {
            totalscore = EnemyCount.enemies;
            SceneManager.LoadScene("GoodDeath");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Damage(damage);
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
        health1 = health;
        if (health <= 0)
        {
            //Animator.Destroy(gameObject);
            SceneManager.LoadScene("GoodDeath");
        }
    }
}