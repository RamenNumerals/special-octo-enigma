using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int lifevalue = 3;
    public GameObject room;
    public AudioSource source;
    public AudioClip death;
    public AudioClip hurt;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (room.GetComponent<GateWay>().inRoom == false)
        {
            this.GetComponent<enemy_follow_player>().enabled = !enabled;
            this.GetComponent<enemypewpew>().enabled = !enabled;

        }
        else
        {
            this.GetComponent<enemy_follow_player>().enabled = enabled;
            this.GetComponent<enemypewpew>().enabled = enabled;

        }
        if (lifevalue <= 0) {

            room.GetComponent<GateWay>().enemyNumber = room.GetComponent<GateWay>().enemyNumber - 1;
            Destroy(this.gameObject);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "playerbullet" || collision.gameObject.tag == "Player" )&& lifevalue > 0)
        {
            source.PlayOneShot(hurt);
            lifevalue--;
            //print(lifevalue);
            
        } else if ((collision.gameObject.tag == "playerbullet" || collision.gameObject.tag == "Player") && lifevalue == 0)
        {
            source.PlayOneShot(death);
            GetComponent<Collider2D>().enabled = false;
            
        }
    } 
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "playerbullet" || collision.gameObject.tag == "Player" && lifevalue > 0)
        {
            lifevalue--;
            //print(lifevalue);

        }
        if ((collision.gameObject.tag == "playerbullet" || collision.gameObject.tag == "Player") && lifevalue == 0)
        {
            source.PlayOneShot(death);
            room.GetComponent<GateWay>().enemyNumber--;
            Destroy(this.gameObject);
        }
    }*/
}
