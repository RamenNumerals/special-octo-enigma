using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Projectile movement

public class projectile : MonoBehaviour
{
    public float gunspeed;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        //asighns rigid body to variable
        Rigidbody2D rbgun = this.gameObject.GetComponent<Rigidbody2D>();
        //adds force
        rbgun.AddForce(transform.up * gunspeed);
        Destroy(this.gameObject, 2f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.name != "clam" && collision.gameObject.name != "knife(clone)" && collision.gameObject.name != "squid gun")
        {
            Destroy(this.gameObject);
        }*/
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
        //transform.position = Vector2.MoveTowards(this.transform.position, enemy.transform.position, gunspeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}