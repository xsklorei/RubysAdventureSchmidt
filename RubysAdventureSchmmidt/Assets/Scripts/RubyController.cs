using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;



    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //create two variables
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        //create movement vector
        Vector2 position = rigidbody2d.position;

        //changing x, y position
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;
        position.y = position.y + 5.0f * vertical * Time.deltaTime;

        //set the updated position
        rigidbody2d.MovePosition(position);
    }



   
}
