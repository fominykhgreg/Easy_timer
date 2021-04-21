using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TImer : MonoBehaviour
{
    // Start is called before the first frame update
    //private DateTime StartTime;
    static bool trigger1 = Button.trigger;

    public float time = 0;
    Text life;

    void Start()
    {
        life = GetComponent<Text>();
    }
   
    // Update is called once per frame

    void Update()
    {
        
        if (Button.trigger == true)
        {
            time += Time.deltaTime;
            
            life.text = "" + time.ToString("00.00"); 


        }
        if (reset_button.reset_trigger == 1)
        {
            time = 0;
            reset_button.reset_trigger = 0;
            life.text = "" + time.ToString("00.00");
            Button.trigger = false;
        }
    }
}
