using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // this is a value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 5, 0);

        //Reference Type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 5, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
