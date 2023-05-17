using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyprojectile : MonoBehaviour
{
    public float gunspeed;

    // Start is called before the first frame update
    void Start()
    {
        //asighns rigid body to variable
        Rigidbody2D rbgun = this.gameObject.GetComponent<Rigidbody2D>();
        //adds force
        rbgun.AddForce(transform.right * gunspeed);
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
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
