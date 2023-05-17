using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateWay : MonoBehaviour
{
    public int enemyNumber;
    public bool inRoom = true;
    public GameObject gate;
    public GameObject cam;
    public Transform camLocation;
    public GameObject[] Enemies;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (enemyNumber <= 0 && inRoom == true)
        {
            gate.SetActive(false);
            

            
        }
        else if (inRoom == false)
        {
            gate.SetActive(true);

        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            inRoom = false;
            

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inRoom = true;
            cam.GetComponent<Transform>().position = camLocation.position;

            foreach (GameObject e in Enemies)
            {
                e.SetActive(true);
            }

        }
    }


}
