using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rbPlayer;

    void Start()
    {



    }

    void Update()
    {

        //If a key is read, do their function
        // "||" means "or"

        //GetKeyUp
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {

            rbPlayer.velocity = new Vector2(0, rbPlayer.velocity.y);

        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {

            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, 0);

        }




        //GetKey
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }

        




    }


    //Movement functions, when called on (see above) their action will happen
    void MoveRight()
    {
      //  print("Meow");

        rbPlayer.velocity = new Vector2(speed, rbPlayer.velocity.y);
        transform.localRotation = Quaternion.Euler(0, 0, 0);

    }

    void MoveLeft()
    {
       // print("Meow");

        rbPlayer.velocity = new Vector2(-speed, rbPlayer.velocity.y);
        transform.localRotation = Quaternion.Euler(0, 180, 0);

    }

    void MoveUp()
    {
       // print("Meow");

        rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, speed);
        transform.localRotation = Quaternion.Euler(0, 0, 90);
    }

    void MoveDown()
    {
      //  print("Meow");

        rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, -speed);
        transform.localRotation = Quaternion.Euler(0, 0, -90);
    }
}



