using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wpillon : MonoBehaviour
{

    public string FootstepWalk;
    public string FootstepRun;
    public string SwordHit;
    public string SwordWoosh;
    public string Shield;
    public string Jump;

    void Start()
    {
        
    }

    
    void Char_FootstepWalk()
    {
        AkSoundEngine.SetSwitch("WP_Mooving", "WALK", gameObject);
        AkSoundEngine.PostEvent(FootstepWalk, gameObject);
    }

    void Char_FootstepRun()
    {
        AkSoundEngine.SetSwitch("WP_Mooving", "RUN", gameObject);
        AkSoundEngine.PostEvent(FootstepRun, gameObject);
    }

    void Char_Jump()
    {
        AkSoundEngine.PostEvent(Jump, gameObject);
    }

    void Char_Sword()
    {
        AkSoundEngine.PostEvent(SwordWoosh, gameObject);
    }

    void Char_SwordHit()
    {
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        AkSoundEngine.PostEvent(SwordHit, gameObject);      
    }

    void Char_Shield()
    {
        AkSoundEngine.PostEvent(Shield, gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        AkSoundEngine.PostEvent(SwordHit, gameObject);
    }
}
