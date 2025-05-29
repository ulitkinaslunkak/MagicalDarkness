using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyD : MonoBehaviour
{
    public int health;
    //public Slider mySlider;
    //public GameObject myUICanvas;
    public GameObject myPlayer;
    //public AudioSource source;
    //public AudioClip sound;
    void Update()
    {
        /*
        //mySlider.value = health;
        if (health < 10)
        {
            myImage.enabled = false;
        }
        else
        {
            myImage.enabled = true;
        }
        
        if (SceneManager.GetActiveScene().name == "Game")
        {
            myUICanvas.SetActive(false);
        }
        */
    }

    public void TakeDamage(int damage)
    {
        if (health - damage <= 0)
        {
            Debug.Log("DIED");
            SceneManager.LoadScene("Game");
            //this.transform.position = new Vector3(49.93f, -9.779f, -197.686f);
            //SoundPlay();
            health = 100;
            //myUICanvas.SetActive(false);
            return;
        }
        health -= damage;
        Debug.Log($"hp: {health}");
    }
    /*
    void SoundPlay()
    {
        source.clip = sound;
        source.Play();
    }

    public void LoadData(GameData data)
    {
        this.health = data.playerHealth;
    }

    public void SaveData(GameData data)
    {
        data.playerHealth = this.health;
    }
    */
}