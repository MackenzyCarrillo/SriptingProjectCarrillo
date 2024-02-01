using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleClass : FruitClass
{
   public AppleClass()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

  
    public AppleClass(string newColor) : base(newColor)
    {
        //Notice how this constructor doesn't set the color
        //since the base constructor sets the color that
        //is passed as an argument.
        Debug.Log("2nd Apple Constructor Called");
    }

}
