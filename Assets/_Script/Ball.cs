using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{

    public float speed = 25;
    private bool ısGameStarted = true;
    public int set;
    void Start()
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

        if (other.gameObject.name == "Right Triggered")
        {
            set = 1;
        }

        if (other.gameObject.name == "Left Triggered")
        {
            set = 2;
        }
        GameManager.Class.UpdateScore(set);
        
    }


    
    
    // ball bounce
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Left Racket")
        {
           float y = BounceMath(transform.position, collision.transform.position, collision.collider.bounds.size);
           Vector2 yon = new Vector2(1, y).normalized;
           GetComponent<Rigidbody2D>().velocity = yon*speed;
        }
        if (collision.gameObject.name == "Right Racket")
        {
            float y = BounceMath(transform.position, collision.transform.position, collision.collider.bounds.size);
            Vector2 yon = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = yon*speed;
        }
           
        
        float BounceMath(Vector2 Top, Vector2 raket, Vector2 bounceS)
        {
            return (Top.y - raket.y) / bounceS.y;



        }
    }

    void Update()
    {
        if (GameManager.Class.Key == true && ısGameStarted == true)
        {
            randomTrans();
            ısGameStarted = false;
        }
         

    }

    
}


