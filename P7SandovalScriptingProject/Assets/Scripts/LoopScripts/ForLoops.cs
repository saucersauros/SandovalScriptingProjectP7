using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    public int chicken = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < chicken; i++)
        {
            Debug.Log("Creating Chicken" + i);
        }
    }
}