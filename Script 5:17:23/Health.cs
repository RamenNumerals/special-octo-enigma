using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public int lifevalue = 3;
    public int maxlife = 3;
    public GameObject spawnpoint;

    public int healAmount = 1;
    public int respawnAmount = 3;
    public Image Healthui;
    public Image Livesui;
    public Sprite[] HealthValueSprites;
    public Sprite[] RespawnAmountLives;
    public AudioSource source;
    public AudioClip heal;
    public AudioClip respawnOuchie;
    public AudioClip death;
    public AudioClip hurt;

    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        
        if (respawnAmount < 0)
        {
            source.PlayOneShot(death);
            SceneManager.LoadScene(2);
        }
        Livesui.sprite = RespawnAmountLives[respawnAmount];
        Healthui.sprite = HealthValueSprites[lifevalue];

    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.gameObject.tag == "spawn") {

            spawnpoint = collision.gameObject;
        }

        

            if (collision.gameObject.tag == "pain" || collision.gameObject.tag == "enemy")
            {
                lifevalue--;
                print(lifevalue);
            source.PlayOneShot(hurt);
            }
            if (lifevalue <= 0)
            {
                 transform.position = new Vector2(spawnpoint.transform.position.x, spawnpoint.transform.position.y);
                 lifevalue = maxlife;
                 respawnAmount--;
            source.PlayOneShot(respawnOuchie);

            }
            //destroys the object Destroy(collision.gameObject);
        

        if (collision.gameObject.tag == "un-pain" && lifevalue < 3)
        {
            lifevalue = lifevalue + healAmount;
            print(lifevalue);
            Destroy(collision.gameObject);
            source.PlayOneShot(heal);
        }
    }
}
