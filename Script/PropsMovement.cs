using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsMovement : MonoBehaviour
{
    public string RTPC_Name;
    public string EventName;
    public Rigidbody rb;

    //[SerializeField] [Range(0f, 1f)]
    //private float VolumeParameterValue = 0;
  
    void Start()
    {
        AkSoundEngine.PostEvent(EventName ,gameObject);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float magnitude = rb.velocity.magnitude;
        if(magnitude > 0)
        {
            AkSoundEngine.SetRTPCValue(RTPC_Name, rb.velocity.magnitude, gameObject);
        }
        //AkSoundEngine.SetRTPCValue(RTPC_Name, rb.velocity.magnitude, gameObject);
        //AkSoundEngine.SetRTPCValue(RTPC_Name, rb.velocity.y, gameObject);
        //AkSoundEngine.SetRTPCValue(RTPC_Name, rb.velocity.x, gameObject);
    }
}
