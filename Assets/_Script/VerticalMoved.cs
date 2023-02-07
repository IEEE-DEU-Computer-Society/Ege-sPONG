using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VerticalMoved : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
        
    }


void FixedUpdate()
{
    if (this.name == "Left Racket")
    {
        float verticalMovedL = Input.GetAxisRaw("VerticalLeft");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovedL*2);
    }

    if (this.name == "Right Racket")
    {
        float verticalMovedR = Input.GetAxisRaw("VerticalRight");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovedR * 2);
    }
        
        
    


} // Vertical Moved



}