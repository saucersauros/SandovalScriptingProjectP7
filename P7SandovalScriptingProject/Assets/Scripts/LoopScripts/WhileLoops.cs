using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public int chicken = 15;
    // Start is called before the first frame update
    void Start()
    {
        while(chicken > 0)
        {
            Debug.Log(chicken + " is so much chicken");
            chicken--;
        }
    }

}