using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float offset;
    public Transform shotPos;
    public GameObject bullet;
    public int amountOfBullets;
    public float spread, bulletSpeed;
    private float guncooldown = 0f;
    public float cooldown = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.U) && guncooldown <= 0)
        {
            Shoot();
            guncooldown = cooldown;
        }

        if (guncooldown > 0)
        {
            guncooldown = guncooldown - Time.deltaTime;
        }
        
    }

    void Shoot()
    {
        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject b = Instantiate(bullet, shotPos.position, shotPos.rotation);
            Rigidbody2D brb = b.GetComponent<Rigidbody2D>();
            Vector2 dir = transform.rotation * Vector2.up;
            Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(-spread, spread);
            brb.velocity = (dir + pdir) * bulletSpeed;
        }
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
}
