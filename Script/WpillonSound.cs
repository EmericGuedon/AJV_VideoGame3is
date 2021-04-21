using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpillonSound : MonoBehaviour
{
    public bool Debug_Enabled = false;

    public AK.Wwise.Event FootstepWalk;
    public float ThresholdWalk;

    public AK.Wwise.Event FootstepRun;
    public float ThresholdRun;

    public AK.Wwise.Event SwordHit;
    public AK.Wwise.Event SwordWoosh;
    public AK.Wwise.Event Shield;
    public AK.Wwise.Event Jump;

    public void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }


    public void Char_FootstepWalk(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > ThresholdWalk)
        {
            Debug.Log("FT_Walk"); 
            AkSoundEngine.SetSwitch("WP_Mooving", "WALK", gameObject);
            FootstepWalk.Post(gameObject);
        }
    }

    public void Char_FootstepRun(AnimationEvent evt)
    {
        if (evt.animatorClipInfo.weight > ThresholdRun)
        {
            Debug.Log("FT_Run");
            AkSoundEngine.SetSwitch("WP_Mooving", "RUN", gameObject);
            FootstepRun.Post(gameObject);
        }
    }

    public void Char_Jump()
    {
        Jump.Post(gameObject);
    }

    public void Char_Sword()
    {
        SwordWoosh.Post(gameObject);
    }

    public void Char_SwordHit()
    {
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }

    public void Char_Shield()
    {
        Shield.Post(gameObject);
        AkSoundEngine.SetState("Sword_Materials", "Dry");
        SwordHit.Post(gameObject);
    }
}
