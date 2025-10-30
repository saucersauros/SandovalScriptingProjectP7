using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        //this line is there to tell me the x position of my object
        Debug.Log(transform.position.x);

    } 
    void Update()
    {     
        //if our game object value is below 5 we want it to show a message on the console
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}