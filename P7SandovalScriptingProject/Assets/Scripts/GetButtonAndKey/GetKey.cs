using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        {
            Debug.Log("Get Key Down is:  " + down);
        }
        else if (held)
        {
            Debug.Log("Key held is:  " + held);
        }
        else if (up)
        {
            Debug.Log("Get Key Up Is:   " + up);
        }
        else
        {
            Debug.Log("Get Key Down is:  " + down);
            Debug.Log("Key held is:  " + held);
            Debug.Log("Get Key Up Is:   " + up);
        }
    }

}
