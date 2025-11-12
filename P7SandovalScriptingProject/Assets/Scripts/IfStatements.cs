using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float coffeeTempature = 85.0f;
    float hotLimitTempature = 70.0f;
    float coldLimitTempature = 40.0f;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTempature -= Time.deltaTime * 5f;

    }


    void TemperatureTest()
    {
        if(coffeeTempature > hotLimitTempature)
        {
            print("my chicken is hot");
        }

        else if(coffeeTempature < coldLimitTempature)
        {
            print("my chicken is cold");
        }

        else
        {
            print("my chicken is just right");
        }

    }
}
