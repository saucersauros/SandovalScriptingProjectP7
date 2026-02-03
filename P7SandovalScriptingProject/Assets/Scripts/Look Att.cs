using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtt : MonoBehaviour
{
    public Transform poop;
    void Update()
    {
        transform.LookAt(poop);
    }

}
