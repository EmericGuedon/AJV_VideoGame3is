using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public string RTPC_Name;
    public Rigidbody Wp;
    public bool Debug_Enabled = true;

    // Update is called once per frame
    public void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
        Wp = GetComponent<Rigidbody>();
    }
    public void OnTriggerEnter(Collider Wp)
    {
        Debug.Log("Sound");
        AkSoundEngine.SetRTPCValue(RTPC_Name, 1f, gameObject);
    }
}
