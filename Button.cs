using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    public static bool trigger = false;
    public void startoletka()
    {
        Handheld.Vibrate();
        if (trigger == true)
        {
            trigger = false;
        }
        else 
        {
            trigger = true;            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
