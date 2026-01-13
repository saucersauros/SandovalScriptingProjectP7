using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFix : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate ()
    {
        Debug.Log("fixed update timee : " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time  : " + Time.deltaTime);
    }
}
