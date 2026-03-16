using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(5, 1, 5);
        Transform tran = transform;
        tran.position = new Vector3(5, 1, 5);
    }

}
