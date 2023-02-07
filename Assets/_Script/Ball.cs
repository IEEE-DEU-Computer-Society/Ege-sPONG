using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 25;

    void Start()
    {
        randomTrans();
    }


    void Update()
    {

    }




    public void randomTrans() //Random Start Func
    {

        int randTrans = Random.Range(1, 3);
        switch (randTrans)
        {
            case 1:
                GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
                break;
            case 2:
                GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
                break;
        }


    }

    void OnTriggerEnter2D(Collider2D other) //Pushing the ball again
    {
        if (other.gameObject.tag == "Kale")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
            randomTrans();
        }
    }


}