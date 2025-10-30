using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunction : MonoBehaviour
{
    int myInt = 5792835;


    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}


