using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{

    public AK.Wwise.Event EventName;
    public string SwitchGroup;
    public string SwitchNoDetect;
    public string SwitchDetect;    
    public int CounterTime;      

    public Rigidbody rb;

    bool detect = false;
    float resetTime = 0;

    public void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
        rb = GetComponent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider rb)
    {
        EventName.Post(gameObject);
        detect = true;  
    }

    private void Update ()
    {
     if(detect) 
      {

       if(resetTime<= CounterTime)   
        {
          AkSoundEngine.SetSwitch(SwitchGroup, SwitchNoDetect, gameObject);
          resetTime+=Time.deltaTime;
        }

       if (resetTime > CounterTime)   
        {        
          AkSoundEngine.SetSwitch(SwitchGroup, SwitchDetect, gameObject);
          detect = false;
          resetTime = 0;
        }
     
      }
    }
    
}
