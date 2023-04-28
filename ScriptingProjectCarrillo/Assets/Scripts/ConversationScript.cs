using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{

    public int intelligence = 5;

    // Start is called before the first frame update
    void Start()
    {
        Greet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Greet()
    {
        switch (intelligence)
        {
            case 5: Debug.Log("Why hello there good sir! Let me teach you about Trigonometry");
                break;

            case 4: Debug.Log("Hello and good day!");
                break;

            case 3: Debug.Log("Whadya want?");
                break;

            case 2: Debug.Log("Grog SMASH!!");
                break;

            case 1: Debug.Log("UghglibpblplbplbpblpblBHJKSRGFFEGFRHJEVFAWERGJJVSEJHBNCYvubfweyrfehayuwerfabaserfhjbfwerghvgwfaeryuuaerghyjaervghjermvewrhjgayuin serv7uerhrfyungc48ngvyuc4ngu vcgu ie");
                break;

            default: Debug.Log("Incorrect intelligence level.");
                break;
         
        }
    }



}
