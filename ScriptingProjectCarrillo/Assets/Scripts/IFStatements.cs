using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLitmitTemperature = 40.0f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();


        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's tempature is greater than the hottest drinking temperature
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // if it isn't, but the coffee tempature is less than the coldest drinking tempature
        else if (coffeeTemperature < coldLitmitTemperature)
        {

            // ... do this.
            print("Coffee is to cold.");
        }

        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }

    }



}

