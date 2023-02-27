using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int lifevalue = 3;
    int maxlife = 3;
    public GameObject spawnpoint;
    public int healAmount = 1;
    public int respawnAmount = 5;
   // public Image Healthui;
   // public Sprite[] Healthsprites;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //    Healthui.sprite = Healthsprites[lifevalue];
        if (respawnAmount < 0)
        {
            Destroy(this.gameObject);
        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy" && lifevalue > 0)
        {
            lifevalue--;
            print(lifevalue);

        }
        //if (respawnAmount > 0)
        //{
            if (lifevalue <= 0)
            {
                transform.position = new Vector2(spawnpoint.transform.position.x, spawnpoint.transform.position.y);
                lifevalue = maxlife;
                respawnAmount--;
            }
        //}
        
    }*/
        private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "pain" || collision.gameObject.tag == "enemy")
            {
                lifevalue--;
                print(lifevalue);
            }
            if (lifevalue <= 0)
            {
                 transform.position = new Vector2(spawnpoint.transform.position.x, spawnpoint.transform.position.y);
                 lifevalue = maxlife;
                 respawnAmount--;

            }
            //destroys the object Destroy(collision.gameObject);
        

        if (collision.gameObject.tag == "un-pain" && lifevalue < 3)
        {
            lifevalue = lifevalue + healAmount;
            print(lifevalue);
            Destroy(collision.gameObject);
        }
    }
}
