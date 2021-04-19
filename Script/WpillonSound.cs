using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpillonSound : MonoBehaviour
{
    public bool Debug_Enabled = false;
    public AK.Wwise.Event FootstepWalk;
    public AK.Wwise.Event FootstepRun;
    public AK.Wwise.Event SwordHit;
    public AK.Wwise.Event SwordWoosh;
    public AK.Wwise.Event Shield;
    public AK.Wwise.Event Jump;

    public void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    
    public void Char_FootstepWalk()
    {
        Debug.Log("FT_Walk");
        //AkSoundEngine.SetSwitch("WP_Mooving", "WALK", gameObject);
        FootstepWalk.Post(gameObject);
    }

    void Char_FootstepRun()
    {
        AkSoundEngine.SetSwitch("WP_Mooving", "RUN", gameObject);
        FootstepRun.Post(gameObject);
    }

    void Char_Jump()
    {
        Jump.Post(gameObject);
    }

    void Char_Sword()
    {
        SwordWoosh.Post(gameObject);
    }

    void Char_SwordHit()
    {
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }

    void Char_Shield()
    {
        Shield.Post(gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }
}
