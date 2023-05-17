using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firechoice : MonoBehaviour
{
    private Animator fireani;
    //public Animation fireone;
    //public Animation firetwo;
    public int choice;
    // Start is called before the first frame update
    void Start()
    {
        fireani=GetComponent<Animator>();
        choice = (int)Random.RandomRange(1f, 2.5f);

        if (choice == 1)
        {

            fireani.Play("fire animation");
        }
        else {


            fireani.Play("fire2");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
