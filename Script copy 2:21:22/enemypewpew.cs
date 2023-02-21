using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemypewpew : MonoBehaviour
{

    private float guncooldown = 1f;
    public float cooldown = 0.4f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 0 is left clisk, 1 is right click, 2 is scrool click for getting mouse code
        if (guncooldown <= 0)
        {
            //3 parts, 1 what are we instantiating, 2 what position, 3 what rotation
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            guncooldown = cooldown;
            //Pani.SetTrigger("Shoot");
        }

        if (guncooldown > 0)
        {
            guncooldown = guncooldown - Time.deltaTime;
        }
    }
}
