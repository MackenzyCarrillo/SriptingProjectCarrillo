using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
   public static void ResetTransform(this Transform transform)
    {
        transform.position = Vector3.zero;
        transform.localRotation = Quaternion.identity;  
        transform.localScale = Vector3.one; 

    }
    
}
