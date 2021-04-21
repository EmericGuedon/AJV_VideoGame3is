using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{

    public string EventName;
    public string SwitchGroup;
    public string SwitchNoDetect;
    public string SwitchDetect;    
    public int CounterTime;        //temps avant que l'event puisse se rejouer

    bool detect = false;
    float resetTime = 0f;

    private void OnTriggerEnter(Collider other)
    {
        //Joue l'event grace au trigger puis active le counter
        AkSoundEngine.PostEvent(EventName, gameObject);       
        detect = true;  
    }

    private void Update ()
    {
     if(detect) 
      {

       if(resetTime<= CounterTime)   //si le counter est inferieur a la valeur donnee il ne joue aucun son
            {
          AkSoundEngine.SetSwitch(SwitchGroup, SwitchNoDetect, gameObject);
          resetTime+=Time.deltaTime;
        }

       if (resetTime > CounterTime)   //si le counter est superieur a la valeur donnee il peut rejouer le son quand il trigg
            {        
          AkSoundEngine.SetSwitch(SwitchGroup, SwitchDetect, gameObject);
          detect = false;
          resetTime = 0f;
        }
     
      }
    }
    
}
