using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;
    private int stapler;
    private int sellotape;

    public void FruitMachine (int a , int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    private void officesort (int a , int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("office supplies total:  " + answer);
    }
}
