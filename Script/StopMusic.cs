using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    //public AK.Wwise.Event NoSoundMusic;
    public string RTPC_Name;
    public Rigidbody Wp;
    public bool Debug_Enabled = true;

    public void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
        Wp = GetComponent<Rigidbody>();
    }
    public void OnTriggerEnter(Collider Wp)
    {
        Debug.Log("NoSound");
        AkSoundEngine.SetRTPCValue(RTPC_Name, 0.4f, gameObject);
    }
}
