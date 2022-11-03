using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    void Start()
    {
        
    }

 
    void Update()
    {
        //create two variables
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //create movement vector
        Vector2 position = transform.position;

        //changing x, y position
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        //set the updated position
        transform.position = position; 
    }
}
