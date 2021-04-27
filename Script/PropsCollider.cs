using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsCollider : MonoBehaviour
{
    
    public AK.Wwise.Event EventName;

    void Start()
    {
        //AkSoundEngine.RegisterGameObj(gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        EventName.Post(gameObject);
    }
}
