using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int lifevalue = 3;
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
    }



    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "playerbullet" && lifevalue > 0)
        {
            lifevalue--;
            print(lifevalue);

        }
        if (lifevalue <= 0)
        {
            Destroy(this.gameObject);
        } 
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerbullet" && lifevalue > 0)
        {
            lifevalue--;
            print(lifevalue);

        }
        if (lifevalue <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
