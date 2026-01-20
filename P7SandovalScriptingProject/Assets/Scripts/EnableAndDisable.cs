using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisable : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (prefab != null)
            {
                prefab.SetActive(!prefab.activeSelf);
            }
        }
    }
}