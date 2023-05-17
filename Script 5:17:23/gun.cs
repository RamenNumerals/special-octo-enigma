using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class gun : MonoBehaviour
{
    public float offset;
    public UnityEngine.UI.Slider CDSlider;
    public Transform shotPos;
    public GameObject bullet;
    public int amountOfBullets;
    public float spread, bulletSpeed;
    private float guncooldown = 0f;
    public float cooldown = 0.4f;
    public AudioSource source;
    public AudioClip shoot;
    
    //public float knockback = 250f;

    // Start is called before the first frame update
    void Start()
    {
        CDSlider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.U) && guncooldown <= 0)
        {
            StartCoroutine(Shoot());
            guncooldown = cooldown;
            source.PlayOneShot(shoot);
        }

        if (guncooldown > 0)
        {
            guncooldown = guncooldown - Time.deltaTime;
        }

        CDSlider.value = guncooldown;

    }

    IEnumerator Shoot()
    {
        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject b = Instantiate(bullet, shotPos.position, shotPos.rotation);
            Rigidbody2D brb = b.GetComponent<Rigidbody2D>();
            Vector2 dir = transform.rotation * Vector2.up;
            Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(-spread, spread);
            brb.velocity = (dir + pdir) * bulletSpeed;
            
        }
        // Non jank physics knockback
        //GetComponent<Rigidbody2D>().AddForce(transform.up * Random.Range(-knockback, knockback));
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;



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
