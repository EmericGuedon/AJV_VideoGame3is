using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtrigger : MonoBehaviour
{

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider rb)
    {
        AkSoundEngine.SetSwitch("Footstep_Materials", "Snow", gameObject);
    }
}