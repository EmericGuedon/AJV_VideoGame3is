using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsCollider : MonoBehaviour
{
    
    public string EventName;

    void Start()
    {      
       
    }

    private void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.PostEvent(EventName, gameObject);
    }
}
